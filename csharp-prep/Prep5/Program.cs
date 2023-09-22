using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = GetName();
        int number = GetNumber();
        DisplayResult(name, number);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string GetName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number * number}");
    }
}