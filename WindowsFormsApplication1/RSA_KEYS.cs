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
            coPrimes = BigInteger.Divide((data.primeOptions.getPrime1() - 1)*(data.primeOptions.getPrime2() - 1), 
                getGCD(data.primeOptions.getPrime1(), data.primeOptions.getPrime2()));

            decryptResultText = new CreateFile();

            counter = 0;

            Parallel.For(2, Int32.MaxValue, (pointer, loopState) =>
            {
                if ((getGCD(pointer, data.primeOptions.getMod()) == 1)
                    && (getGCD(pointer, coPrimes) == 1))
                {
                    counter++;

                    if (counter == encryptionCount)
                    {
                        encryptKey = pointer;
                        loopState.Break();
                    }
                }
            }
            );

            counter = 0;
            decryptKey = 1;

            Parallel.For(0, Int32.MaxValue, (temp, loopState) =>
            {
                product = BigInteger.Multiply(encryptKey, temp);

                if (BigInteger.Remainder(product, coPrimes) == 1)
                {
                    temp++;
                    counter++;

                    if (counter > decryptCount)
                    {
                        decryptKey = temp - 1;

                        loopState.Break();
                    }
                }
            }
            );

          /*for(BigInteger pointer = 2; pointer < coPrimes; pointer++)
         {
        if ((getGCD(pointer, data.primeOptions.getMod()) == 1) 
            && (getGCD(pointer, coPrimes) == 1))
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
            decryptKey = 1;*/

            /*while ((counter < decryptCount) && (decryptKey < coPrimes))
            {
                decryptKey = decryptKey + 1;

                product = BigInteger.Multiply(encryptKey, decryptKey);

                /*if (HasRemainderOne(product, coPrimes))
                {
                    counter++;
                }

            /*if(modifiedMod(product, 1, coPrimes) == 1)
            {
                counter++;
            }*/
            /*
            if(BigInteger.Remainder(product, coPrimes) == 1)
            {
                counter++;
            }
        }*/

            decryptResultText.CreateFileEncrypt(decryptKey, encryptKey);

            //decryptText.Text = decryptKey + " is the decryption key";
            return data.primeOptions.success();

            //Form3 data1 = new Form3(this);
            //data1.Show();
        }

        BigInteger modifiedMod(BigInteger baseVal, BigInteger expVal, BigInteger modVal)
        {
            BigInteger remainder = 1;

            /*for (BigInteger i = 1; i <= expVal; i++)
            {
                remainder *= baseVal;
                remainder = remainder % modVal;
            }*/

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
            //BigInteger divisorCounter;

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
            
            /*for (;;)
            {
                //divisorCounter = bigNumber % divisor;

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
            }*/

            while(divisor != 0)
            {
                remainder = divisor;
                divisor = bigNumber % divisor;
                bigNumber = remainder;
            }

            return remainder;
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

            /*for (;;)
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
            }*/

            remainder = bigNumber % divisor;

            if(remainder == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}