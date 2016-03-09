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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Form2 data;

        public Form3(Form2 a)
        {
            data = a;

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
            BigInteger[] encryptMessageInHex = new BigInteger[messageLen]; //Holds value after being powered
            BigInteger[] messageCipher = new BigInteger[messageLen]; //Holds the encrypted message

            BigInteger mod = data.form.getMod();
            int encryptKey = data.form.getEncrypt();

            for (int i = 0; i < messageLen; i++)
            {
                messageInHex[i] = Convert.ToByte(message[i]);

                encryptMessageInHex[i] = BigInteger.Pow(messageInHex[i], encryptKey);
                messageCipher[i] = encryptMessageInHex[i]%mod;

                messageEncrypted = messageEncrypted + (messageCipher[i]);
            }

            EncryptedText.Text = "'" + messageEncrypted + "' is your cipher.";
        }
    }
}
