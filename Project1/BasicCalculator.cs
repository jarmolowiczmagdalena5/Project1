using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class BasicCalculator
    {
        int number1;
        int number2;

        public int Addiction(int number1, int number2)
        {
            return (number1 + number2);
        }
        public int Subtraction(int number1, int number2)
        {
            return (number1 - number2);
        }
        public int Multiplication(int number1, int number2)
        {
            return (number1 * number2);
        }
        public int Division(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
}
