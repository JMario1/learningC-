
using System.Collections.Generic;
using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Dictionary<int, BankAccount> Accounts = new Dictionary<int, BankAccount>();
            Console.WriteLine("Welome to Mi-Bank !!!\n");
            Console.Write("Available accounts: ");
            for(int i =1; i<=5; i++)
            {
                string name = "John Doe " + i;
                int num = CreateBankAccount(name, Accounts);
                Console.Write(num+ ", ");
            }
            while(true)
            {
                Console.WriteLine("\n\nTo create a bank account press 1");
                Console.WriteLine("To make a deposit press 2");
                Console.WriteLine("To make a withdrawel press 3");
                Console.WriteLine("To check account balance press 4");
                Console.WriteLine("To get account details press 5");
                Console.WriteLine("To close and delete account press 6 \n");
                Console.Write("Select an option: ");
                string action = Console.ReadLine();

                if(action == "1")
                {
                    Console.Write("Please enter your full name: ");
                    string name = Console.ReadLine();
                    int num = CreateBankAccount(name, Accounts);
                    Console.WriteLine("\nSuccessfully created account, your account number is {0}", num);
                }

                else if(action == "2")
                {
                    Console.Write("Please enter account number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Enter amount you wish to deposit: ");
                    int amount = int.Parse(Console.ReadLine());
                    if(Accounts.ContainsKey(num) == true && amount > 0)
                    {
                        BankAccount acc = Accounts[num];
                        acc.Deposit(amount);
                        acc.lastDeposit = amount;
                    }
                    else if(amount < 0)
                    {
                        Console.WriteLine("Negative numbers not allowed!!!");
                    }
                    else
                    {
                        Console.WriteLine("Account number provided does not exist");
                    }
                }
                else if(action == "3")
                {
                    Console.Write("Please enter account number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Enter amount you wish to withdraw: ");
                    int amount = int.Parse(Console.ReadLine());
                    if(Accounts.ContainsKey(num) == true && amount > 0)
                    {
                        BankAccount acc = Accounts[num];
                        acc.Withdrawel(amount);
                        acc.lastWithdrawel  = amount;
                    }
                    else if(amount < 0)
                    {
                        Console.WriteLine("Negative numbers not allowed!!!");
                    }
                    else
                    {
                        Console.WriteLine("Account number provided does not exist");
                    }
                }

                else if(action == "4")
                {
                    Console.Write("Please enter account number: ");
                    int num = int.Parse(Console.ReadLine());
                    if(Accounts.ContainsKey(num) == true)
                    {
                        BankAccount acc = Accounts[num];
                        acc.CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("Account number provided does not exist");
                    }
                }

                else if(action == "5")
                {
                    Console.Write("Please enter account number: ");
                    int num = int.Parse(Console.ReadLine());
                    if(Accounts.ContainsKey(num) == true)
                    {
                        BankAccount acc = Accounts[num];
                        acc.AccountDetails();
                    }
                    else
                    {
                        Console.WriteLine("Account number provided does not exist");
                    }
                }

                else if(action == "6")
                {
                    Console.Write("Please enter account number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("This action is irreversible, are you sure? y/n: ");

                    string del = Console.ReadLine();
                        if(del == "y" || del == "Y")
                        {
                        if(Accounts.ContainsKey(num) == true)
                        {
                            DeleteBankAccount(num, Accounts);
                        }
                        else
                        {
                            Console.WriteLine("Account number provided does not exist");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }

                Console.Write("Do you want to perform another operation y/n: " );
                string exit = Console.ReadLine();
                if(exit == "n" || exit == "N")
                {
                    break;
                }
            }
            
        }

        static int CreateBankAccount(string name, Dictionary<int, BankAccount> accounts) 
        {
            BankAccount acc = new BankAccount();
            acc.name = name;
            Random rng = new Random();
            int num = rng.Next(1111, 9999);
            while(accounts.ContainsKey(num))
            {
                num = rng.Next(1111, 9999);
            }
            acc.accountNumber = num;
            accounts.Add(num, acc);
            return num;
        }
        

        static void DeleteBankAccount(int accountNumber, Dictionary<int, BankAccount> accounts) 
        {
            accounts.Remove(accountNumber);
            Console.WriteLine("successfully delete account");

        }
    }
}
