public class Menu
{
    private string _activity;
    public string DisplayMenu()
    {
        Console.Write("Menu Options:\n\t0. Start Breathing Activity\n\t1. Start Reflecting Activity\n\t2. Start Listing Activity\n\t3. Quit\nSelect a choice from the menu: ");
        _activity = Console.ReadLine();
        return _activity;
    }
}