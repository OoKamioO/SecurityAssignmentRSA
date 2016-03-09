using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form1 form;
        int decryptCount;
        int mod;
        int encrypt;

        public Form2(Form1 a)
        {
            form = a;
            encrypt = form.getEncrypt();
            mod = form.getMod();

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(decrpytBox.Text, out decryptCount))
            {
                int counter = 0;
                int decryptKey = 0; //i.e. the multiple
                int product = 0;

                while (counter < decryptCount)
                {
                    decryptKey++;

                    product = encrypt * decryptKey;

                    if (product % mod == 1)
                    {
                        counter++;
                    }
                }

                //decryptText.Text = decryptKey + " is the decryption key";
                decryptText.Text = decryptKey + " is the decrypt";

                Form3 form1 = new Form3(this);
                form1.Show();
            }
            else
            {
                decryptText.Text = "Please enter a number.";
            }
        }
    }
}
