using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class ExtendedCalculator
    {
        public bool PrimeNumber(int num1)
        {
            bool primenumber = true;
            for (int i = 2; i < num1; i++)
            {
                
                if (num1 % i == 0)
                    primenumber=false;

            }
            return primenumber;
        }
        public int GetFactorial(int number1)
        {
            int result = 1;
                for (int i = 1; i <= number1; i++)
                {
                    result *= i;
                }
            return result;
        }
    }
}
