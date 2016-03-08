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
    public partial class Form1 : Form
    {
        int prime1;
        int prime2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int encryptKey = 0;

            if (Int32.TryParse(textBox1.Text, out prime1) && Int32.TryParse(textBox2.Text, out prime2))
            {
                if (prime1 != prime2)
                {
                    Prime checkPrime1 = new Prime(prime1);
                    Prime checkPrime2 = new Prime(prime2);

                    if (checkPrime1.calculateIfPrime() && checkPrime2.calculateIfPrime())
                    {
                        /*Numbers are prime*/
                        int mod = (prime1 - 1) * (prime2 - 2); //Number of cooprimes in the product of prime1 and prime2

                        for(int i = 2; i < mod; i++)
                        {
                            if((i%prime1 != 0) && (i%prime2 != 0) && (i%mod != 0))
                            {
                                encryptKey = i;
                            }
                        }

                        primeText.Text = encryptKey + " is the encrypt key";

                    }
                    else
                    {
                        /*Numbers are even*/
                        primeText.Text = "Please enter prime numbers";
                    }
                }
                else
                {
                    primeText.Text = "Please enter unique Numbers";
                }
            }
            else
            {
                primeText.Text = "Please enter numbers";
            }
        }
    }
}
