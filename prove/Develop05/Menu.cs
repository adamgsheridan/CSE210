class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:\n\t1. Create new goal\n\t2. List goals\n\t3. Save goals\n\t4. Load goals\n\t5. Record event\n\t6. Quit");
    }
    public int GetSelector()
    {
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }

    public void DisplayGoalTypes()
    {
        Console.WriteLine("The types of goals are:\n\t1. Simple goal\n\t2. Eternal goal\n\t3. Checklist goal");
    }

    public int GetGoalType()
    {
        Console.Write("Which type of goal would you like to create: ");
        return int.Parse(Console.ReadLine());
    }
}