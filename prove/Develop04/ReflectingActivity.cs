public class ReflectingActivity
{
    List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    List<string> _newQuestions = new List<string> {"0", "1", "2", "3"};

    public void DisplayInstructions()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
    }

    public string GetPrompt()
    {
        Random rnd = new Random();
        string newPrompt = _prompts[rnd.Next(0, 4)];
        return newPrompt;
    }

    public List<string> GetQuestions()
    {
        Random rnd = new Random();
        _newQuestions[0] = _questions[rnd.Next(0, 9)];
        _newQuestions[1] = _questions[rnd.Next(0, 9)];
        while(_newQuestions[0] == _newQuestions[1])
        {
            _newQuestions[1] = _questions[rnd.Next(0, 9)];
        }
        _newQuestions[2] = _questions[rnd.Next(0, 9)];
        while(_newQuestions[1] == _newQuestions[2] || _newQuestions[0] == _newQuestions[2])
        {
            _newQuestions[2] = _questions[rnd.Next(0, 9)];
        }
        return _newQuestions;
    }
    public void Reflect(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Activity activity = new Activity();
        activity.Spinner();
        string prompt = GetPrompt();

        Console.Write("Consider the following prompt:\n\n\t--- ");
        Console.Write(prompt);
        Console.Write(" ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        for(int i = 5; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        Console.WriteLine();

        List<String> questions = GetQuestions();
        Console.Write("> " + questions[0]);
        activity.SpecificSpinner(duration);
        Console.Write("\n> " + questions[1]);
        activity.SpecificSpinner(duration);
        Console.Write("\n> " + questions[2]);
        activity.SpecificSpinner(duration);

        Console.WriteLine("\n\nWell done!\nYou have completed another " + duration + "seconds of the Reflecting Activity.");

        activity.Spinner();
        

    }
}