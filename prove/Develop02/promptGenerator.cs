public class PromptGenerator
{
    public void Greeting()
    {
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }

    public string GetInput()
    {
        string choice = Console.ReadLine();
        return choice;
    }

    public string GetFilename()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();
        return filename;
    }
}