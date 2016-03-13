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
    public partial class Form3 : Form
    {
        FileStream file;

        CreateFile cipherText;

        Form2 data;

        public Form3(Form2 a)
        {
            data = a;

            cipherText = new CreateFile();

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string message = EncryptBox.Text;
            string messageEncrypted = null; //Holds encrypted message in string format
            int messageLen = EncryptBox.Text.Length; 

            BigInteger[] messageInHex = new BigInteger[messageLen]; //Gives each character their HEX value
            BigInteger encryptMessageInHex = new BigInteger(); //Holds value after being powered
            BigInteger charCipher = new BigInteger(); //Holds the encrypted message
            
            BigInteger publicKey = data.form.getMod();
            BigInteger encryptionKey = data.getEncryptKey();

            cipherText.CheckExists();

            for (int i = 0; i < messageLen; i++)
            {
                messageInHex[i] = Convert.ToByte(message[i]);

                encryptMessageInHex = Power(messageInHex[i], encryptionKey);

                charCipher = encryptMessageInHex % publicKey;

                cipherText.CreateFileCipherText(charCipher);
            }
            
            EncryptedText.Text = "Done";
        }

        BigInteger Power(BigInteger a, BigInteger b)
        {
            BigInteger pro = a;

            for (int i = 0; i < b; i++)
            {
                pro = BigInteger.Multiply(pro, a);
            }

            return pro;
        }

        /*int remainder(BigInteger i, int k)
        {

        }*/
    }
}
