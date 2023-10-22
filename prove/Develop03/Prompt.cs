public class Prompt
{
    private string _continue;
    public void PromptContinue()
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        _continue = Console.ReadLine();
    }

    public bool ShouldContinue()
    {
        return _continue != "quit";
    }
}