/*using System;
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
            string filePath;
            int messageLen = EncryptBox.Text.Length; 

            BigInteger[] messageInHex = new BigInteger[messageLen]; //Gives each character their HEX value
            BigInteger encryptMessageInHex = new BigInteger(); //Holds value after being powered
            BigInteger charCipher = new BigInteger(); //Holds the encrypted message
            
            BigInteger publicKey = data.form.getMod();
            BigInteger encryptionKey = data.getEncryptKey();
            BigInteger decryptKey = data.getDecryptKey();

            cipherText.CheckExists();

            for (int i = 0; i < messageLen; i++)
            {
                messageInHex[i] = Convert.ToByte(message[i]);

                Console.WriteLine(messageInHex[i]);

                encryptMessageInHex = Power(messageInHex[i], encryptionKey);

                charCipher = encryptMessageInHex % publicKey;

                cipherText.CreateFileCipherText(charCipher);
            }

            filePath = cipherText.returnPath();

            EncryptedText.Text = "Done" + encryptMessageInHex;

            Form4 form = new Form4(this, filePath, publicKey, decryptKey);
            form.Show();
        }

        BigInteger Power(BigInteger a, BigInteger b)
        {
            BigInteger pro = 1;

            for (int i = 0; i < b; i++)
            {
                pro = pro * a;
            }

            return pro;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
*/