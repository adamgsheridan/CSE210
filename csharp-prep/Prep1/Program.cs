using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your lastname? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}