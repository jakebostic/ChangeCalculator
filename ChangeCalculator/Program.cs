using System;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");
            Console.WriteLine();

            Console.Write("Enter number of cents (0-99): ");
            if (int.TryParse(Console.ReadLine(), out int cents))
            {
                Console.WriteLine();

                int quarters = cents / 25;
                cents %= 25;
                int dimes = cents / 10;
                cents %= 10;
                int nickels = cents / 5;
                int pennies = cents % 5;

                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes:    " + dimes);
                Console.WriteLine("Nickels:  " + nickels);
                Console.WriteLine("Pennies:  " + pennies);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
