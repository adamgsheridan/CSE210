public class Write
{
    private PromptGenerator _prompt;
    public Write()
    {
        this._prompt = new PromptGenerator();
    }

    Random rnd = new Random();
    public Entry WriteEntry()
    {
        string[] inspiration = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?"
         , "If I had one thing I could do over today, what would it be?"};
        string prompt = inspiration[rnd.Next(5)];
        Console.Write(prompt + "\n> ");
        string entryText = this._prompt.GetInput();
        Entry entry = new Entry();
        entry._text = entryText;
        entry._prompt = prompt;
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        return entry;
    }
}