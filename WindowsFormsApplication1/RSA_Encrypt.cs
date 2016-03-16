using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public class RSA_Encrypt
    {
        CreateFile cipherText;

        Form1 data;

        public RSA_Encrypt(Form1 a)
        {
            data = a;

            cipherText = new CreateFile();
        }

        public String encryptText(String text)
        {
            string message = text;
            string filePath;
            int messageLen = text.Length;

            BigInteger[] messageInHex = new BigInteger[messageLen]; //Gives each character their HEX value
            BigInteger encryptMessageInHex = new BigInteger(); //Holds value after being powered
            BigInteger charCipher = new BigInteger(); //Holds the encrypted message

            BigInteger publicKey = data.primeOptions.getMod();
            BigInteger encryptionKey = data.keyOptions.getEncryptKey();
            BigInteger decryptKey = data.keyOptions.getDecryptKey();

            cipherText.CheckExists();

            for (int i = 0; i < messageLen; i++)
            {
                messageInHex[i] = Convert.ToByte(message[i]);

                encryptMessageInHex = Power(messageInHex[i], encryptionKey);

                charCipher = encryptMessageInHex % publicKey;

                cipherText.CreateFileCipherText(charCipher);
            }

            filePath = cipherText.returnPath();

            return text = data.primeOptions.success();
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
    }
}
