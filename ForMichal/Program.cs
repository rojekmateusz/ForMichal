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
                Console.WriteLine("Witamy w aplikacji bankomat!");
                Console.WriteLine($"Podaj PIN aby się zalogować. Masz {count} próby");
                userInput = int.Parse(Console.ReadLine());
                count--;
                Console.Clear();
                if (count == 0)
                {
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"Zalogowano do systemu");
            Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");

            Console.Clear();

            /******* Obsluga konta ********************************************/

            int accounBalance = 50000;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Stan konta");
                Console.WriteLine("2. Wplac");
                Console.WriteLine("3. Wyplac");
                Console.WriteLine("4. Wyjscie \n");
                Console.WriteLine("Wybierz opcje: ");

                int input = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (input)
                {

                    case 1:
                        Console.WriteLine($"Stan konta: {accounBalance}PLN");
                        Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Jaką kwotę chcesz wpłacić?");
                        Console.WriteLine("1: 20PLN");
                        Console.WriteLine("2: 50PLN");
                        Console.WriteLine("3: 100PLN");
                        Console.WriteLine("4: 200PLN");
                        Console.WriteLine("5: 500PLN");

                        int payment = int.Parse(Console.ReadLine());
                        switch (payment)
                        {
                            case 1:
                                accounBalance = accounBalance + 20;
                                Console.WriteLine("Do aktualnego stanu konta dodano 20PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 2:
                                accounBalance = accounBalance + 50;
                                Console.WriteLine("Do aktualnego stanu konta dodano 50PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 3:
                                accounBalance = accounBalance + 100;
                                Console.WriteLine("Do aktualnego stanu konta dodano 100PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 4:
                                accounBalance = accounBalance + 200;
                                Console.WriteLine("Do aktualnego stanu konta dodano 200LN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 5:
                                accounBalance = accounBalance + 500;
                                Console.WriteLine("Do aktualnego stanu konta dodano 500PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("Nieprawidłowa opcja. Spróbuj jeszcze raz.");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;
                        }

                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Jaką kwotę chcesz wypłacić?");
                        Console.WriteLine("1: 20PLN");
                        Console.WriteLine("2: 50PLN");
                        Console.WriteLine("3: 100PLN");
                        Console.WriteLine("4: 200PLN");
                        Console.WriteLine("5: 500PLN");

                        int paycheck = int.Parse(Console.ReadLine());
                        switch (paycheck)
                        {
                            case 1:
                                accounBalance = accounBalance - 20;
                                Console.WriteLine("Z aktualnego stanu konta odjęto 20PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 2:
                                accounBalance = accounBalance - 50;
                                Console.WriteLine("Z aktualnego stanu konta odjęto 50PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 3:
                                accounBalance = accounBalance - 100;
                                Console.WriteLine("Z aktualnego stanu konta odjęto 100PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 4:
                                accounBalance = accounBalance - 200;
                                Console.WriteLine("Z aktualnego stanu konta odjęto 200LN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            case 5:
                                accounBalance = accounBalance - 500;
                                Console.WriteLine("Z aktualnego stanu konta odjęto 500PLN");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("Nieprawidłowa opcja. Spróbuj jeszcze raz.");
                                Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                Console.ReadKey();
                                break;
                        }

                        Console.Clear();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj jeszcze raz.");
                        Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }

        }
    }
}
