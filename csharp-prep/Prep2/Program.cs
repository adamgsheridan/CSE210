using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            Console.WriteLine("Your final grade is an A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your final grade is a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your final grade is a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your final grade us a D.");
        }
        else
        {
            Console.WriteLine("Your final grade is an F.");
        }
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You failed the class.");
        }
    }
}