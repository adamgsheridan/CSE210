class CheckingAccount : Account
{
    private float _overdraftFee;
    public CheckingAccount(string _name, float _balance, string _address, int _accountNumber, int _routingNumber, float _overdraftFee)
    {
        this._name = _name;
        this._balance = _balance;
        this._address = _address;
        this._accountNumber = _accountNumber;
        this._routingNumber = _routingNumber;
        this._overdraftFee = _overdraftFee;
    }

    public override float GetOverdraftFee()
    {
        Console.WriteLine("How much are overdraft fees for the new account? ");
        return int.Parse(Console.ReadLine());
    }

    // public int GetAccountNumber(Account tempAcc)
    // {
    //     Console.Write("What is the Account Number of the account that you want to use to calculate interest.");
    //     int tempAccNum = int.Parse(Console.ReadLine());
    //     if(_accountNumber == tempAccNum)
    //     {
    //         return 
    //     }
    // }
    public override bool CompareAccount(Account account, int tempAccNum)
    {
        if(tempAccNum == _accountNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}