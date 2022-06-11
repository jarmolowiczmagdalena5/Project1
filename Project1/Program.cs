using Project1;

Menu basicMenu = new Menu();
BasicCalculator BasicCalculator = new BasicCalculator();

basicMenu.BasicMenu();
int basicMenuChoice = Convert.ToInt32(Console.ReadLine());
switch (basicMenuChoice)
{
    case 1:
        basicMenu.Calculator();
        break;
    case 2:
        basicMenu.ExtendedCalculator();
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
        Console.WriteLine(BasicCalculator.Addiction(number1, number2));
        break;
    case 2:
        Console.WriteLine(BasicCalculator.Subtraction(number1, number2));
        break;
    case 3:
        Console.WriteLine(BasicCalculator.Multiplication(number1, number2));
        break;
    case 4:
        Console.WriteLine(BasicCalculator.Division(number1, number2));
        break;
}