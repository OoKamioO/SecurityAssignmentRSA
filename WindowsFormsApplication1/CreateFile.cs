using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CreateFile
    {
        FileStream file1;
        StreamWriter fileWrite;

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
    }
}