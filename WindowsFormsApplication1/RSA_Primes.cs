using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public class RSA_Primes
    {
        private BigInteger prime1, prime2;
        private BigInteger mod;
        private String message;

        CreateFile primeFile = new CreateFile();

        public RSA_Primes()
        {
        }

        public String checkNumbers(String prime1, String prime2)
        {
            if ((BigInteger.TryParse(prime1, out this.prime1)) &&
            (BigInteger.TryParse(prime2, out this.prime2)))
            {
                message = calculatePrimes();
                return message;
            }
            else
            {
                return message = numbersOnly();
            }
        }

        public String calculatePrimes()
        {
                if (prime1 != prime2)
                {
                    Prime checkPrime1 = new Prime(prime1);
                    Prime checkPrime2 = new Prime(prime2);

                    if (checkPrime1.calculateIfPrime() && checkPrime2.calculateIfPrime())
                    {
                        /*Numbers are confirmed prime*/
                        mod = prime1 * prime2;

                        primeFile.CreateFilePrime(prime1, prime2, mod);

                        return success();

                        //Form2 form = new Form2(this);
                        //form.Show();
                    }
                    else
                    {
                        return primesOnly();
                    }
                }
                else
                {
                    return uniqueOnly();
                }
            }

        public BigInteger getMod()
        {
            return mod;
        }

        public BigInteger getPrime1()
        {
            return prime1;
        }

        public BigInteger getPrime2()
        {
            return prime2;
        }

        public String success()
        {
            return "SUCCESS";
        }

        public String primesOnly()
        {
            return "PRIMES ONLY";
        }

        public String uniqueOnly()
        {
            return "UNIQUE ONLY";
        }

        public String numbersOnly()
        {
            return "NUMBERS ONLY";
        }

        public String noValueText()
        {
            return "NO VALUES FOUND";
        }

        public String fieldsEmpty()
        {
            return "FIELDS EMPTY";
        }
    }
}
