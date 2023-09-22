using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1, 101);

        int guess = 0;
        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess > magicNumber)
            {
                Console.WriteLine("The number you're looking for is lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("The number you're looking for is higher.");
            }
        }
        Console.Write($"You got it right! The number was {guess}!");
    }
}