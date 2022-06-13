using Project1;

Menu basicMenu = new Menu();
BasicCalculator basicCalculator = new BasicCalculator();
ExtendedCalculator extendedCalculator = new ExtendedCalculator();

basicMenu.ShowBasicMenu();
int basicMenuChoice = Convert.ToInt32(Console.ReadLine());
switch (basicMenuChoice)
{
    case 1:
        {
            basicMenu.ShowCalculatorMenu();
            int basicCalculatorChoice = Convert.ToInt32(Console.ReadLine());
            switch (basicCalculatorChoice)
            {
                case 1:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Wynik: " + basicCalculator.Addiction(number1, number2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Wynik: " + basicCalculator.Subtraction(number1, number2));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Wynik: " + basicCalculator.Multiplication(number1, number2));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Wynik: " + basicCalculator.Division(number1, number2));
                        break;
                    }
            }
            break;
        }
    case 2:
        {
            basicMenu.ShowExtendedCalculatorMenu();
            int extendedCalculatorChoice = Convert.ToInt32(Console.ReadLine());
            switch (extendedCalculatorChoice)
            {
                case 1:
                    {
                        Console.WriteLine("Podaj liczbę");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(extendedCalculator.GetPrimeNumber(number));
                        bool primeNumber = extendedCalculator.GetPrimeNumber(number);
                        if (primeNumber)
                            Console.WriteLine("Liczba pierwsza");
                        else
                            Console.WriteLine("To nie jest liczba pierwsza");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj liczbę");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int result = extendedCalculator.GetFactorial(number);
                        Console.WriteLine("Silnia z liczby " + number + "to: " + result);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj liczbę");
                        int number = Convert.ToInt32(Console.ReadLine());
                        bool greatNumber = extendedCalculator.GetGreatNumber(number);
                        if (greatNumber)
                            Console.WriteLine("Liczba doskonała");
                        else
                            Console.WriteLine("To nie jest liczba doskonała");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj podstawę potęgi");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj wykładnik potęgi");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Wynik: " + extendedCalculator.GetPowerOfNumber(number1, number2));
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Podaj ilość liczb");
                        int amountOfNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczby do średniej");
                        int[] numbers = new int[amountOfNumber];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Średnia wybranych liczba to: " + extendedCalculator.GetAverageOfNumbers(numbers));
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Podaj ilość liczb");
                        int amountOfNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczby, które chcesz sprawdzić");
                        int[] numbers = new int[amountOfNumber];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Najmniejszą liczbą jest: " + extendedCalculator.GetSmallestNumber(numbers));
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Podaj ilość liczb");
                        int amountOfNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczby, które chcesz sprawdzić");
                        int[] numbers = new int[amountOfNumber];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Największą liczbą jest: " + extendedCalculator.GetLargestNumber(numbers));
                        break;
                    }
            }
            break;
        }
}




