using Project1;


Console.ForegroundColor = ConsoleColor.Yellow;
Menu basicMenu = new Menu();
BasicCalculator basicCalculator = new BasicCalculator();
ExtendedCalculator extendedCalculator = new ExtendedCalculator();
TextFile textFile = new TextFile();

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
                        ExtendedConsole.WriteResult("Wynik: " + basicCalculator.Addiction(number1, number2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        ExtendedConsole.WriteResult("Wynik: " + basicCalculator.Subtraction(number1, number2));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        ExtendedConsole.WriteResult("Wynik: " + basicCalculator.Multiplication(number1, number2));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        ExtendedConsole.WriteResult("Wynik: " + basicCalculator.Division(number1, number2));
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
                            ExtendedConsole.WriteResult("Liczba pierwsza");
                        else
                            ExtendedConsole.WriteError("To nie jest liczba pierwsza");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj liczbę");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int result = extendedCalculator.GetFactorial(number);
                        ExtendedConsole.WriteResult("Silnia z liczby " + number + "to: " + result);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj liczbę");
                        int number = Convert.ToInt32(Console.ReadLine());
                        bool greatNumber = extendedCalculator.GetGreatNumber(number);
                        if (greatNumber)
                            ExtendedConsole.WriteResult("Liczba doskonała");
                        else
                            ExtendedConsole.WriteError("To nie jest liczba doskonała");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj podstawę potęgi");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj wykładnik potęgi");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        ExtendedConsole.WriteResult("Wynik: " + extendedCalculator.GetPowerOfNumber(number1, number2));
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
                        ExtendedConsole.WriteResult("Średnia wybranych liczba to: " + extendedCalculator.GetAverageOfNumbers(numbers));
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
                        ExtendedConsole.WriteResult("Najmniejszą liczbą jest: " + extendedCalculator.GetSmallestNumber(numbers));
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
                        ExtendedConsole.WriteResult("Największą liczbą jest: " + extendedCalculator.GetLargestNumber(numbers));
                        break;
                    }
            }
            break;
        }
    case 3:
        {
            basicMenu.ShowTextFileMenu();
            int textFileChoice = Convert.ToInt32(Console.ReadLine());
            string file = @"C:\Users\jarmo\source\repos\Project1\TxtFile.txt";
            switch (textFileChoice)
            {
                case 1:
                    {
                        if (File.Exists(file))
                        {
                            Console.WriteLine("Wyświetlanie pliku:\n");
                            string[] lines = File.ReadAllLines(file);
                            foreach (string line in lines)
                                Console.WriteLine(line);
                        }
                        else
                            Console.WriteLine("Plik nie istnieje");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj linię, linię chcesz wyświetlić");
                        int line = Convert.ToInt32(Console.ReadLine());
                        string[] lines = File.ReadAllLines(file);
                        Console.WriteLine(lines[line - 1]);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Dodaj tekst");
                        string text = Console.ReadLine();
                        textFile.AddAllTextToFile(text);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj linię, w której chcesz dodać tekst");
                        int line = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj text jaki chcesz dodać");
                        string text = Console.ReadLine();
                        textFile.AddLineToFile(line, text);
                        break;
                    }
            }
            break; 
        }
}
Console.ResetColor();


