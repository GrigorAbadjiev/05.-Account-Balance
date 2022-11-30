using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;

            while (input != "NoMoreMoney")
            {
                double inputAsNumber = double.Parse(input);
                if (inputAsNumber < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {inputAsNumber:f2}");
                totalSum += inputAsNumber;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
