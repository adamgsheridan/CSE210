using System;
class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();
        Menu menu = new Menu();
        int mainSelector = menu.MainMenu();
        while(mainSelector != 6)
        {
            AccountManager accountManager = new AccountManager();
        
            if(mainSelector == 1)
            {
                int newAcc = menu.CreationMenu();
                string name = account.GetName();
                float balance = account.GetBalance();
                string address = account.GetAddress();
                int accountNumber = account.GetAccountNumber();
                int routingNumber = account.GetRoutingNumber();
                if(newAcc == 1)
                {
                    float overdraftFee = CheckingAccount.GetOverdraftFee();
                    Account newChecking = new CheckingAccount(name, balance, address, accountNumber, routingNumber, overdraftFee);
                    accountManager.CreateAccount(newChecking);
                }
                else if(newAcc == 2)
                {
                    float interestRate = SavingsAccount.GetInterestRate();
                    int transactionLimit = SavingsAccount.GetTransactionLimit();
                    Account newSavings = new SavingsAccount(name, balance, address, accountNumber, routingNumber, interestRate, transactionLimit);
                    accountManager.CreateAccount(newSavings);
                }
                
            }
            else if (mainSelector == 2)
            {
                Account interestAccount = accountManager.GetAccount();
                account.GetInterest(interestAccount);
            }
            else if (mainSelector == 3)
            {}
            else if (mainSelector == 4)
            {}
            else if (mainSelector == 5)
            {}
            mainSelector = menu.MainMenu();
        }
    }
}