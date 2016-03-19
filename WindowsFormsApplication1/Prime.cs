using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public class Prime
    {
        private BigInteger num;

        public Prime()
        {
        }

        public Prime(BigInteger prime)
        {
            num = prime;
        }

        public Boolean calculateIfPrime()
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false; //Not a Prime Number
                }
            }

            return true;   //Is a Prime Number
        }

        public String createPrimes()
        {
            Random rnd = new Random();
            Boolean isPrime = false;
            String prime;

            int a = rnd.Next(70000, 100000);

            while(!isPrime)
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        //Not a prime
                        a = rnd.Next(70000, 100000);

                        i = 2;
                    }
                }

                isPrime = true;
            }

            return prime = a.ToString();
        }
    }
}
