namespace ForMichal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******* Uzyskanie dostepu do konta *******************************/

            int pin = 1234;
            int count = 3;
            int userInput = 0;

            while (pin != userInput)
            {
                Console.WriteLine($"Podaj pin masz {count} próby");
                userInput = int.Parse(Console.ReadLine());
                count--;
                if (count == 0)
                {
                    Environment.Exit(0);
                }
            }
            Console.Clear();

            /******* Obsluga konta ********************************************/

            int accounBalance = 50000;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Stan konta");
                Console.WriteLine("2. Wplac");
                Console.WriteLine("3. Wyplac");
                Console.WriteLine("4. Wyjscie");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {

                    case 1:
                        Console.WriteLine($"Stan konta: {accounBalance}PLN");
                        Console.Read();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine($"Wpłata");
                        Console.Read();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine($"Wypłata");
                        Console.Read();
                        Console.Clear();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;


                    default:
                        break;

                }
            }

        }
    }
}
