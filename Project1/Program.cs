using Project1;

Menu basicMenu = new Menu();
BasicCalculator basicCalculator = new BasicCalculator();

basicMenu.ShowBasicMenu();
int basicMenuChoice = Convert.ToInt32(Console.ReadLine());
switch (basicMenuChoice)
{
    case 1:
        basicMenu.ShowCalculatorMenu();
        break;
    case 2:
        basicMenu.ShowExtendedCalculatorMenu();
        break;
}
int basicCalculatorChoice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj liczbe 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj liczbe 2");
int number2 = Convert.ToInt32(Console.ReadLine());

switch (basicCalculatorChoice)
{
    case 1:
        Console.WriteLine(basicCalculator.Addiction(number1, number2));
        break;
    case 2:
        Console.WriteLine(basicCalculator.Subtraction(number1, number2));
        break;
    case 3:
        Console.WriteLine(basicCalculator.Multiplication(number1, number2));
        break;
    case 4:
        Console.WriteLine(basicCalculator.Division(number1, number2));
        break;
}