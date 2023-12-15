class SavingsAccount : Account
{
    private float _interestRate;
    private int _transactionLimit;
    public SavingsAccount(string _name, float _balance, string _address, int _accountNumber, int _routingNumber, float _interestRate, int _transactionLimit)
    {
        this._name = _name;
        this._balance = _balance;
        this._address = _address;
        this._accountNumber = _accountNumber;
        this._routingNumber = _routingNumber;
        this._interestRate = _interestRate;
        this._transactionLimit = _transactionLimit;
    }

    public static float GetInterestRate()
    {
        Console.Write("What is the yearly interest rate for the new account? ");
        return float.Parse(Console.ReadLine());
    }

    public static int GetTransactionLimit()
    {
        Console.Write("What is the limit of transactions per month for this acount? ");
        return int.Parse(Console.ReadLine());
    }
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

    public override void GetInterest(Account account)
    {
        // balance * year * payments per period
        float balanceWithInterest = _balance * 1 * _interestRate;
        Console.WriteLine($"In one year your account balance will be ${balanceWithInterest} due to the interest.");
    }
}