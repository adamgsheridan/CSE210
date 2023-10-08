using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        prompt.Greeting();
        string choice = prompt.GetInput();
        while (choice != "5")
        {
            if (choice == "1")
            {
                Write write = new Write();
                Entry entry = write.WriteEntry();
                journal._entries.Add(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine(journal);
            }
            else if (choice == "3")
            {
                string filename = prompt.GetFilename();
                FileManager loadFileManager = new FileManager();
                journal = loadFileManager.LoadJournal("journal.txt");
            }
            else if (choice == "4")
            {
                string filename = prompt.GetFilename();
                FileManager fileManager = new FileManager();
                fileManager.SaveJournal(journal, "journal.txt");
            }
            prompt.Greeting();
            choice = prompt.GetInput();
        }
    }
}

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public override string ToString()
    {
        string journalString = "";
        foreach (Entry entry in this._entries)
        {
            journalString += entry.ToString();
        }
        return journalString;
    }
}
public class Entry
{
    public string _text;
    public string _prompt;
    public string _date;
    public override string ToString()
    {
        return "Date: " + this._date + " - Prompt: " + this._prompt + "\n" + this._text + "\n\n";
    }
}