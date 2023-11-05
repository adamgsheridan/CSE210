public class Activity
{
    private int _duration;
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }

    public void Spinner()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void SpecificSpinner(int duration)
    {
        int fractDuration = duration * 1000 / 36;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("-");
            Thread.Sleep(fractDuration);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(fractDuration);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(fractDuration);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(fractDuration);
            Console.Write("\b \b");
        }
    }
}