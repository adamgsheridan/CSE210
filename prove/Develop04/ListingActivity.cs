using System.Security.Principal;

public class ListingActivity
{
    List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    int _entries = 0;
    public void DisplayInstructions()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n\nThis activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.\n");
    }
    private string GetPrompt()
    {
        Random rnd = new Random();
        string newPrompt = _prompts[rnd.Next(0, 4)];
        return newPrompt;
    }

    public void Listing(int duration)
    {
        Console.WriteLine("Get ready...");
        Activity activity = new Activity();
        activity.Spinner();
        Console.Write("\nList as many responses as you can to the following prompt:\n\n\t--- ");
        string prompt = GetPrompt();
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

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            _entries += 1;
        }
        Console.WriteLine("You listed " + _entries + " items");
        Console.WriteLine("Well done!!!\n\nYou have completed another " + duration + " seconds of the Listing Activity.");
        activity.Spinner();
    }
}