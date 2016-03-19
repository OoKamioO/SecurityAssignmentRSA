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

            byte[] letterInHex = new byte[messageLen]; //Gives each character their HEX value
            String messageInHex = ""; //Holds message in Hexadecimal
            String encryptMessageInHex = ""; //Holds encrypted message value after being powered

            BigInteger publicKey = data.primeOptions.getMod();
            BigInteger encryptionKey = data.keyOptions.getEncryptKey();
            BigInteger decryptKey = data.keyOptions.getDecryptKey();

            cipherText.CheckExists();

            letterInHex = Encoding.Default.GetBytes(message);

            messageInHex = BitConverter.ToString(letterInHex);
            messageInHex = messageInHex.Replace("-", "");

            Byte[] letterInHex2 = new Byte[messageInHex.Length];

            letterInHex2 = Encoding.Default.GetBytes(messageInHex);

            messageInHex = BitConverter.ToString(letterInHex2);
            messageInHex = messageInHex.Replace("-", "");

            BigInteger hexValueInBigInt;
            BigInteger.TryParse(messageInHex, out hexValueInBigInt);

            encryptMessageInHex = (modifiedMod(hexValueInBigInt, encryptionKey, publicKey)).ToString();

            Console.WriteLine(hexValueInBigInt);

            /*for (int i = 0; i < messageLen; i++)
            {
                letterInDec[i] = Convert.ToByte(message[i]);

                encryptMessageInDec = encryptMessageInDec + letterInDec[i];
            }*/

            /*encryptMessageInHex = Power(messageInHex[i], encryptionKey);
            charCipher = encryptMessageInHex % publicKey;*/
            cipherText.CreateFileCipherText(encryptMessageInHex);

            filePath = cipherText.returnPath();

            return text = data.primeOptions.success();
        }

        BigInteger modifiedMod(BigInteger baseVal, BigInteger expVal, BigInteger modVal)
        {
            BigInteger remainder = 1;

            /*for (BigInteger i = 1; i <= expVal; i++)
            {
                remainder *= baseVal;
                remainder = remainder % modVal;
            }*/

            while(expVal > 0)
            {
                if(expVal%2 != 0)
                {
                    remainder *= baseVal;
                    remainder = remainder % modVal;
                }

                expVal /= 2;
                baseVal = (baseVal * baseVal) % modVal;
            }
            
            return remainder;
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

        public BigInteger Remainder(BigInteger a, BigInteger b)
        {
            BigInteger bigNumber;
            BigInteger divisionCount;
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

            for (;;)
            {
                divisionCount = bigNumber / divisor;

                remainder = BigInteger.Subtract(bigNumber, (divisor * divisionCount));

                if (remainder < divisor)
                {
                    return remainder;
                }
            }
        }
    }
}
