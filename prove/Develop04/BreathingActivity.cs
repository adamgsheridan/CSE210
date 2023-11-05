public class BreathingActivity
{
    private int _randomNum;
    private int _breathCount = 0;
    private int _tempDuration;
    public void DisplayInstructions()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Breath(int duration)
    {
        Console.WriteLine("Get ready...");
        Activity activity = new Activity();
        activity.Spinner();
        

        Console.WriteLine("\n");
        _tempDuration = duration;
        while (_tempDuration > 0)
        {
            // Get random number between 0 and duration and assign it to random number.
            Random rnd = new Random();
            if(_tempDuration > 10)
            {
                _randomNum = rnd.Next(3, 10);
            }
            else if (_tempDuration >= 5)
            {
                _randomNum = rnd.Next(_tempDuration);

            }
            else
            {
                _randomNum = _tempDuration;
            }

            // Determine if the user should breath in or out.
            if(_breathCount % 2 == 1)
            {
                Console.Write("Breath out...");
            }
            else
            {
                Console.Write("Breath in...");
            }
            _breathCount++;
            
            // Countdown.
            for (int i = _randomNum; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                if (i > 9)
                {
                    Console.Write("\b \b\b \b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
            Console.Write("\n");
            // Subtract the random number from duration.
            _tempDuration -= _randomNum;

            if(_breathCount % 2 == 0 || _tempDuration == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("Well done!!");
        activity.Spinner();
        Console.WriteLine();

        Console.WriteLine("You have completed another " + duration + " seconds of the Breathing Activity.");
        activity.Spinner();
    }
}