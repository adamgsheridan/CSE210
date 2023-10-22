using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        string refer = reference.GetReference();
        Console.Write(refer);

        Scripture scripture = new Scripture();
        scripture.PrintScripture();

        Prompt prompt = new Prompt();
        prompt.PromptContinue();

        while(prompt.ShouldContinue() && scripture.HasWordToHide())
        {
            Console.Clear();
            Console.Write(refer);
            scripture.WriteScriptureWithHiddenWords();
            prompt.PromptContinue();
        }
    }
}