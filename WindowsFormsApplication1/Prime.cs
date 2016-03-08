using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Prime
    {
        private int num;

        public Prime(int prime)
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
