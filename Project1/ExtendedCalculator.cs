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
        public int GetAverageOfNumbers(int[] numbers)
        {
            int Sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];
            }
            return Sum / numbers.Length;
        }
        public int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        }
        public int GetLargestNumber(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }
    }
}
