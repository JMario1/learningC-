using System;


namespace BankApp
{
    class BankAccount
    {
        public string name ="";
        public int accountNumber = 0;
        public int lastDeposit = 0;
        public int lastWithdrawel = 0;
        int balance = 0;

        

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Successfully depoited " + amount);
            Console.WriteLine("current balance is " + balance);
        } 
        public void Withdrawel(int amount) 
        {
            if(amount > balance)
            {
                Console.WriteLine("Insufficent fund");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Successfullly withdraw " + amount);
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("Your aaccount balance is " + balance);
        }    

        public void AccountDetails()
        {
            Console.WriteLine("Account Name: " + name);
            Console.WriteLine("Account Number: " + accountNumber + "\n");
            Console.WriteLine("Your last deposit was " + lastDeposit);
            Console.WriteLine("Your last withdrawel was " + lastWithdrawel + "\n");
            Console.WriteLine("Account Balance: " + balance);
        }
    }
}