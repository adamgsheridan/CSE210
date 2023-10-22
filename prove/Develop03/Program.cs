using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.PrintScripture();

        Prompt prompt = new Prompt();
        prompt.PromptContinue();

        while(prompt.ShouldContinue() && scripture.HasWordToHide())
        {
            Console.Clear();
            scripture.WriteScriptureWithHiddenWords();
            prompt.PromptContinue();
        }
    }
}