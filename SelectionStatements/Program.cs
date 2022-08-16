using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game.");
            Console.WriteLine("See if you can what number I am thinking of...");
            Console.WriteLine("Hint: My number is between 1-100.");
            var random = new Random();
            var cpuNumber = random.Next(1, 100);
            int userInput;
            do
            {
                Console.WriteLine("Enter your guess:");
                userInput = int.Parse(Console.ReadLine());
                if (userInput > cpuNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (userInput < cpuNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("You guessed it! Good job!");
                }
            } while (userInput != cpuNumber);
        }
    }
}
