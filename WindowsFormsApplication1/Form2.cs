using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        CreateFile decryptResultText;

        public Form1 form;
        BigInteger decryptCount;
        BigInteger encryptionCount;
        BigInteger coPrimes;
        BigInteger encryptKey;

        BigInteger decryptKey = 0; //i.e. the multiple
        BigInteger product = 0;

        public Form2(Form1 a)
        {
            form = a;

            decryptResultText = new CreateFile();
            
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
            BigInteger counter = 0;

            coPrimes = (form.getPrime1() - 1) * (form.getPrime2() - 1); //Number of cooprimes in the product of prime1 and prime2

            if (BigInteger.TryParse(encryptionBox.Text, out encryptionCount) &&
                BigInteger.TryParse(decrpytBox.Text, out decryptCount))
            {
                if (encryptionCount > 1)
                {
                    counter = 0;

                    for (BigInteger pointer = 2; pointer < coPrimes; pointer++)
                    {
                        if ((pointer % form.getPrime1() != 0) && (pointer % form.getPrime2() != 0) && (pointer % form.getMod() != 0))
                        {
                            encryptKey = pointer;

                            counter++;
                        }

                        if (counter == encryptionCount)
                        {
                            break;
                        }
                    }

                    counter = 0;

                    while (counter < decryptCount)
                    {
                        decryptKey++;

                        product = encryptKey * decryptKey;

                        if (Remainder(product, coPrimes))
                        {
                            counter++;
                        }
                    }

                    //decryptText.Text = decryptKey + " is the decryption key";
                    decryptText.Text = decryptKey + " is the decrypt.";
                    encryptText.Text = encryptKey + " is the encrypt.";

                    decryptResultText.CreateFileEncrypt(decryptKey, encryptKey);

                    Form3 form1 = new Form3(this);
                    form1.Show();
                }
                else
                {
                    decryptText.Text = "Enter an encryption number greater than 1.";
                }
            }
            else
            {
                decryptText.Text = "Please enter numbers.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void decryptText_Click(object sender, EventArgs e)
        {

        }

        public BigInteger getEncryptKey()
        {
            return encryptKey;
        }

        public BigInteger getDecryptKey()
        {
            return decryptKey;
        }

        public Boolean Remainder(BigInteger a, BigInteger b)
        {
            BigInteger bigNumber;
            BigInteger divisor;
            
            BigInteger remainder; //Placeholder value

            if (a > b)
            {
                bigNumber = a;
                divisor = b;
            }
            else
            {
                bigNumber = b;
                divisor = a;
            }

            for(;;)
            {
                remainder = bigNumber;
                bigNumber = BigInteger.Subtract(bigNumber, divisor);

                if (bigNumber <= 0)
                {
                    return false;
                }

                if (bigNumber == 1)
                {
                    return true;
                }
            }
        }
    }
}
