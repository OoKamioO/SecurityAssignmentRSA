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

        public Prime(BigInteger prime)
        {
            num = prime;
        }

        public Boolean calculateIfPrime()
        {
            for(int i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    return false; //Not a Prime Number
                }
            }

            return true;   //Is a Prime Number
        }

        public static implicit operator int(Prime v)
        {
            throw new NotImplementedException();
        }
    }
}
