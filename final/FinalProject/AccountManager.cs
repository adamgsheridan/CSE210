class AccountManager
{
    public List<Account> _account = new List<Account>();

    Account account = new Account();
    public void CreateAccount(Account account)
    {
        _account.Add(account);
    }



    public Account GetAccount()
    {
        Console.Write("What is the Account Number of the account to be used to calculate interest? ");
        int tempAccNum;
        tempAccNum = int.Parse(Console.ReadLine());
        foreach(Account acc in _account)
        {
            bool containsNumber = account.CompareAccount(acc, tempAccNum);
            if(containsNumber)
            {
                return acc;
            }
        }
        return null;
    }
}