using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public class RSA_decrypt
    {
        Form1 data;
        String filePath;
        CreateFile decryptFile;
        BigInteger publicKey;
        BigInteger decryptKey;

        public RSA_decrypt(Form1 a, String p)
        {
            data = a;

            filePath = p;
            publicKey = data.primeOptions.getMod();
            decryptKey = data.keyOptions.getDecryptKey();

            decryptFile = new CreateFile();
        }

        public String decryptText()
        { 
                decryptFile.ReadCipherText(filePath, publicKey, decryptKey);

                return data.primeOptions.success();
        }
    }
}
