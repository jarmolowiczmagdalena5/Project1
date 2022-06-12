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
                        Console.WriteLine(basicCalculator.Addiction(number1, number2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(basicCalculator.Subtraction(number1, number2));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(basicCalculator.Multiplication(number1, number2));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj liczbe 1");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(basicCalculator.Division(number1, number2));
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
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(extendedCalculator.PrimeNumber(num1));
                        bool primenumber = extendedCalculator.PrimeNumber(num1);
                        if (primenumber)
                            Console.WriteLine("Liczba pierwsza");
                        else
                            Console.WriteLine("To nie jest liczba pierwsza");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj liczbę");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int result = extendedCalculator.GetFactorial(number1);
                        Console.WriteLine("Silnia z liczby " + number1 + "to: " + result);
                        break;
                    }
            }
            break;
        }
}




