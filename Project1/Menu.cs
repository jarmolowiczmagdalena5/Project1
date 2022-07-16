namespace Project1
{
    internal class Menu
    {
        public void ShowBasicMenu()
        {
            Console.WriteLine("Wybierz funkcję w menu:");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Operacje matematyczne");
            Console.WriteLine("3. Plik tekstowy");
        }
        public void ShowCalculatorMenu()
        {
            Console.WriteLine("Wybierz funkcję kalkluatora:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
        }
        public void ShowExtendedCalculatorMenu()
        {
            Console.WriteLine("Wybierz funkcję:");
            Console.WriteLine("1. Liczba pierwsza");
            Console.WriteLine("2. Silnia");
            Console.WriteLine("3. Liczba doskonała");
            Console.WriteLine("4. Potęgi");
            Console.WriteLine("5. Średnia liczb");
            Console.WriteLine("6. Najmniejsza liczba ze zbioru");
            Console.WriteLine("7. Największa liczba ze zbioru");
        }
        public void ShowTextFileMenu()
        {
            Console.WriteLine("Wybierz funkcję:");
            Console.WriteLine("1. Odczytanie pełnego pliku");
            Console.WriteLine("2. Odczytanie wybranej lini");
            Console.WriteLine("3. Dodanie tekstu do pliku");
            Console.WriteLine("4. Dodanie tekstu w konkretnej linii");
        }
    }
}
