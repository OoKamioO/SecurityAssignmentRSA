using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        Form3 data;
        string filePath;
        CreateFile decryptFile;
        BigInteger publicKey;
        BigInteger decryptKey;

        public Form4(Form3 a, string p, BigInteger pKey, BigInteger dKey)
        {
            data = a;

            filePath = p;
            publicKey = pKey;
            decryptKey = dKey;

            decryptFile = new CreateFile();

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(decryptTextLink.Text != "")
            {
                decryptFile.ReadCipherText(decryptTextLink.Text, publicKey, decryptKey);

                decryptedText.Text = "Done";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void decryptTextLink_TextChanged(object sender, EventArgs e)
        {
            decryptTextLink.Text = filePath;
        }
    }
}
