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

            File.WriteAllText(pathString, "The decryption key is: " + dKey.ToString());
            File.WriteAllText(pathString, "The encryption key is: " + eKey.ToString());
        }

        public void ReadCipherText(string p, BigInteger publicKey, BigInteger decryptKey)
        {
            BigInteger realLetter;

            int lineCount = File.ReadLines(p).Count();
            String[] messageInHex = new String[lineCount];

            int counter = 0;

            fileName = "decrypt.txt";

            pathString = Path.Combine(folderName, fileName);

            file1 = File.Create(pathString);
            file1.Close();

            String line;

            file1 = new FileStream(p, FileMode.Open, FileAccess.ReadWrite);
            fileRead = new StreamReader(file1);
            fileWrite = new StreamWriter(file1);

            while ((line = fileRead.ReadLine()) != null)
            {
                realLetter = Power(Convert.ToInt16(line), decryptKey);

                messageInHex[counter] = (realLetter%publicKey).ToString() + Environment.NewLine;

                counter++;
            }
            
            file1.Close();

            file2 = new FileStream(pathString, FileMode.Open, FileAccess.ReadWrite);
            fileWrite = new StreamWriter(file2);

            String message = "";
            char[] message2 = new char[lineCount];

            for(int i = 0; i < lineCount; i++)
            {
                int value = Convert.ToInt32(messageInHex[i]);
                char c = Convert.ToChar(value);
                message = message + c;
            }

            fileWrite.WriteLine(message);

            fileWrite.Close();
        }

        public void CreateFileDecrypt()
        {
            fileName = "decrypt.txt";

            pathString = Path.Combine(folderName, fileName);

            file1 = File.Create(pathString);
            file1.Close();
        }

        public void CreateFileCipherText(BigInteger cipher)
        {
            /*fileName = "cipher.txt";

            pathString = Path.Combine(folderName, fileName);

            if (!File.Exists(fileName))
            {
                pathString = Path.Combine(folderName, fileName);

                file1 = File.Create(pathString);
                //file1 = File.WriteAllText(pathString, cipher.ToString() + Environment.NewLine);
                file1.Close();
            }*/

            fileWrite = File.AppendText(pathString);
            fileWrite.WriteLine(cipher.ToString());

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

        public string returnPath()
        {
            return pathString;
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