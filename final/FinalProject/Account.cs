class Account
{
    protected string _name;
    protected float _balance;
    protected string _address;
    protected int _accountNumber;
    protected int _routingNumber;

    public string GetName()
    {
        Console.Write("What's the name of the account holder? ");
        return Console.ReadLine();
    }

    public float GetBalance()
    {
        Console.Write("What's the balance for the new account? ");
        return float.Parse(Console.ReadLine());
    }

    public string GetAddress()
    {
        Console.WriteLine("What's the account holder's mailing address? ");
        return Console.ReadLine();
    }

    public int GetAccountNumber()
    {
        Console.WriteLine("What is the new account's Account Number? ");
        return int.Parse(Console.ReadLine());
    }

    public int GetRoutingNumber()
    {
        Console.WriteLine("What is the new account's Routing Number? ");
        return int.Parse(Console.ReadLine());
    }

    virtual public bool CompareAccount(Account account, int tempAccNum)
    {
        return false;
    }
    virtual public void GetInterest(Account account)
    {}
}