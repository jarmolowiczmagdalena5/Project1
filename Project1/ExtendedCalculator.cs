using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class ExtendedCalculator
    {
        public bool GetPrimeNumber(int number)
        {
            bool primeNumber = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    primeNumber = false;
                    break;
                }
            }
            return primeNumber;
        }
        public int GetFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        public bool GetGreatNumber(int number)
        {
            bool greatNumber;
            int result = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    result += i;
                }
            }
            if (result == number)
                greatNumber = true;
            else
                greatNumber = false;
            return greatNumber;
        }
        public int GetPowerOfNumber(int number1, int number2)
        {
            int result = number1;
            for (int i = 1; i < number2; i++)
            {
                result *= number1;
            }
            return result;
        }
        public int GetAverageOfNumbers(int[] Numbers)
        {
            int Sum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Sum += Numbers[i];
            }
            int result = Sum / Numbers.Length;
            return result;
        }
        public int GetSmallestNumber(int[] Numbers)
        {
            int smallest = Numbers[0];
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < smallest)
                {
                    smallest = Numbers[i];
                }
            }
            return smallest;
        }
        public int GetLargestNumber(int[] Numbers)
        {
            int largest = Numbers[0];
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] > largest)
                {
                    largest = Numbers[i];
                }
            }
            return largest;
        }
    }
}
