using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public class RSA_KEYS
    {
        CreateFile decryptResultText;

        Form1 data;
        BigInteger decryptCount;
        BigInteger encryptionCount;
        BigInteger coPrimes;
        BigInteger encryptKey;

        BigInteger decryptKey = 0; //i.e. the multiple
        BigInteger product = 0;

        String message;

        public RSA_KEYS(Form1 a)
        {
            data = a;
        }

        public String checkKeys(String encryptionSet, String decryptionSet)
        {
            if (BigInteger.TryParse(encryptionSet, out encryptionCount) &&
                BigInteger.TryParse(decryptionSet, out decryptCount))
            {
                message = getKeys();
                return message;
            }
            else
            {
                return message = data.primeOptions.numbersOnly();
            }
        }

        public String getKeys()
        {
            BigInteger counter = 0;

            //Number of cooprimes in the product of prime1 and prime2
            coPrimes = (data.primeOptions.getPrime1() - 1) * (data.primeOptions.getPrime2() - 1);

            decryptResultText = new CreateFile();

            counter = 0;

            for (BigInteger pointer = 2; pointer < coPrimes; pointer++)
            {
                if ((getGCD(pointer, data.primeOptions.getMod()) == 1) && (getGCD(pointer, coPrimes) == 1))
                {
                    encryptKey = pointer;

                    counter++;
                }

                //Selected Encryption key from set
                if (counter == encryptionCount)
                {
                    break;
                }
            }

            counter = 0;
            
            while (counter < decryptCount)
            {
                decryptKey++;

                product = BigInteger.Multiply(encryptKey, decryptKey);

                if (HasRemainderOne(product, coPrimes))
                {
                    counter++;
                }
            }

            decryptResultText.CreateFileEncrypt(decryptKey, encryptKey);

            //decryptText.Text = decryptKey + " is the decryption key";
            return data.primeOptions.success();

            //Form3 data1 = new Form3(this);
            //data1.Show();
        }

        public BigInteger getEncryptKey()
        {
            return encryptKey;
        }

        public BigInteger getDecryptKey()
        {
            return decryptKey;
        }

        public BigInteger Multiply(BigInteger a, BigInteger b)
        {
            BigInteger result = 0;

            for(BigInteger i = 0; i < b; i++)
            {
                result = result + a;
            }

            return result;
        }

        public BigInteger getGCD(BigInteger a, BigInteger b)
        {
            BigInteger bigNumber;
            BigInteger divisor;
            BigInteger temp;

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

            remainder = divisor;

            for (;;)
            {
                bigNumber = BigInteger.Subtract(bigNumber, divisor);

                if (bigNumber == 0)
                {
                    return remainder;
                }

                if (bigNumber < divisor)
                {
                    remainder = bigNumber;
                    bigNumber = divisor;
                    divisor = remainder;
                }
            }
        }

        public Boolean HasRemainderOne(BigInteger a, BigInteger b)
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

            for (;;)
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