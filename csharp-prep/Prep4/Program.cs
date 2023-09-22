using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while (true)
        {
            Console.Write("Please enter a number (Enter 0 to STOP): ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        int total = 0;
        int counter = 0;
        foreach (var num in numbers)
        {
            total += num;
            counter += 1;
        }
        Console.Write($"The total is {total}. ");

        float average = (float)total / (float)counter;
        Console.Write($"The average of those numbers is {average}.");
    }
}