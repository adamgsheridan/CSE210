using System;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        string _selectedActivity = menu.DisplayMenu();

        Activity activity = new Activity();
        while (_selectedActivity != "3")
        {
            if (_selectedActivity == "0")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayInstructions();
                int duration = activity.GetDuration();
                breathing.Breath(duration);
            }
            else if (_selectedActivity == "1")
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.DisplayInstructions();
                int duration = activity.GetDuration();
                reflecting.Reflect(duration);
            }
            else if (_selectedActivity == "2")
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.DisplayInstructions();
                int duration = activity.GetDuration();
                listing.Listing(duration);
            }
            Console.Clear();
            _selectedActivity = menu.DisplayMenu();


        }
    }
}