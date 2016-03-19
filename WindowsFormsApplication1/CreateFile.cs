using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace WindowsFormsApplication1
{
    class CreateFile
    {
        FileStream file1;
        FileStream file2;
        StreamWriter fileWrite;
        StreamReader fileRead;

        string folderName;
        string subFolderName;
        string pathString;
        string fileName;

        public CreateFile()
        {
            folderName = @"C:\RSA";
            subFolderName = "RSA_Texts";

            pathString = System.IO.Path.Combine(folderName, subFolderName);

            if (!System.IO.Directory.Exists(pathString))
            {
                System.IO.Directory.CreateDirectory(pathString);
            }
        }

        public void CreateFilePrime(BigInteger prime1, BigInteger prime2, BigInteger publicKey)
        {
            fileName = "Primes.txt";

            string[] primes = { "Prime 1: " + prime1,
                "Prime 2: " + prime2,
                "Public Key: " + publicKey};

            pathString = System.IO.Path.Combine(folderName, fileName);

            /*if (!System.IO.File.Exists(pathString))
            {
                System.IO.File.Create(pathString);
            }*/

            file1 = File.Create(pathString);
            file1.Close();

            File.WriteAllLines(pathString, primes);
        }

        public void CreateFileEncrypt(BigInteger dKey, BigInteger eKey)
        {
            fileName = "encrypt.txt";

            pathString = Path.Combine(folderName, fileName);

            file1 = File.Create(pathString);
            file1.Close();

            File.WriteAllText(pathString, "The decryption key is: " + dKey.ToString() + Environment.NewLine + 
                "The encryption key is: " + eKey.ToString());
        }

        public void ReadCipherText(string p, BigInteger publicKey, BigInteger decryptKey)
        {
            String cipherMessage;
            
            fileName = "decrypt.txt";

            pathString = System.IO.Path.Combine(folderName, fileName);

            file1 = File.Create(pathString);
            file1.Close();

            String messageInCipher;
            BigInteger messageInCipherBigInt;

            file1 = new FileStream(p, FileMode.Open, FileAccess.ReadWrite);
            fileRead = new StreamReader(file1);
            fileWrite = new StreamWriter(file1);

            messageInCipher = fileRead.ReadLine();

            BigInteger.TryParse(messageInCipher, out messageInCipherBigInt);

            Console.WriteLine("M: " + messageInCipherBigInt);
            Console.WriteLine("Dkey: " + decryptKey);
            Console.WriteLine("PKey: " + publicKey);

            cipherMessage = modifiedMod(messageInCipherBigInt, decryptKey, publicKey).ToString();

            //cipherMessage = (Power(messageInCipherBigInt, decryptKey) % publicKey).ToString();

            Console.WriteLine("PCipher: " + cipherMessage);

            messageInCipher = HexString2Ascii(cipherMessage);

            cipherMessage = HexString2Ascii(messageInCipher);

            Console.WriteLine(cipherMessage);

            //messageInHex[counter] = (realLetter%publicKey).ToString() + Environment.NewLine;

            file1.Close();

            file2 = new FileStream(pathString, FileMode.Open, FileAccess.ReadWrite);
            fileWrite = new StreamWriter(file2);

            fileWrite.WriteLine(cipherMessage);
            fileWrite.Close();
        }

        public void CreateFileDecrypt()
        {
            fileName = "decrypt.txt";

            pathString = Path.Combine(folderName, fileName);

            file1 = File.Create(pathString);
            file1.Close();
        }

        public void CreateFileCipherText(String cipher)
        {
            fileWrite = File.AppendText(pathString);
            fileWrite.WriteLine(cipher);

            fileWrite.Close();
        }

        public void CheckExists()
        {
            fileName = "cipher.txt";

            if (!File.Exists(fileName))
            {
                pathString = Path.Combine(folderName, fileName);

                file1 = File.Create(pathString);
                //File.WriteAllText(pathString, "Hi" + Environment.NewLine);
                file1.Close();
            }

            file1.Close();

            /*if (!File.Exists(fileName))
            {
                return false;
            }*/
        }

        private string HexString2Ascii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 2; i += 2)
            {
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
            }
            return sb.ToString();
        }

        /*private string HexString2Ascii(string hexString)
        {
            String messageInHex = "";

            for (int i = 0; i < hexString.Length - 2; i += 2)
            {
                String value1 = "" + hexString[i];
                String value2 = "" + hexString[i + 1];
                String hexValue = value1 + value2;

                messageInHex = messageInHex + Convert.ToChar(Convert.ToUInt32(hexValue, 16));
            }

            return messageInHex;
        }*/

        public string returnPath()
        {
            return pathString;
        }

        BigInteger modifiedMod(BigInteger baseVal, BigInteger expVal, BigInteger modVal)
        {
            BigInteger remainder = 1;

            while (expVal > 0)
            {
                if (expVal % 2 != 0)
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

            for (BigInteger i = 0; i < b; i++)
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

                //Console.WriteLine(divisionCount);

                remainder = BigInteger.Subtract(bigNumber, (divisor*divisionCount));

                //Console.WriteLine(remainder);

                //remainder = bigNumber;
                //bigNumber = BigInteger.Subtract(bigNumber, divisor);

                if (remainder < divisor)
                {
                    return remainder;
                }
            }
        }
    }
}