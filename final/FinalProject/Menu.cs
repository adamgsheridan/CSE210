class Menu
{
    public int MainMenu()
    {
        Console.WriteLine("Welcome to CSE210 Banking!\n\t1. Create new account");
        Console.WriteLine("\t2. Calculate interest\n\t3. Save Account\n\t4. Load Account\n\t5. Delete Account\n\t6. End program");
        Console.Write("Please select an option to continue: ");
        return int.Parse(Console.ReadLine());
    }

    public int CreationMenu()
    {
        Console.Clear();
        Console.WriteLine("Here are the possible types of accounts to create:\n\t1. Checking Account\n\t2. SavingsAccount");
        Console.Write("What type of account would you like to create? ");
        return int.Parse(Console.ReadLine());
    }
}