using System;

namespace ConsoleGame
{
    /**
        TODO:
            - Account name, number and balance all need to be private
            - Add functionality to check if account number exists after generating and generate again if it does
    */

    public class Accounts
    {
        public string accountName;
        public int accountNumber;
        public double accountBalance;

        public Accounts(string name, double balance)
        {
            accountName = name;
            accountNumber = GenerateRandom();
            accountBalance = balance;
        }
        
        public static int GenerateRandom()
        {
            Random generator = new Random();
            return generator.Next(0, 10000000);
        }

        public void getAccountDetail(string type)
        {
            switch (type)
            {
                case "name":
                    Console.WriteLine(accountName);
                    break;
                case "number":
                    Console.WriteLine(accountNumber);
                    break;

                case "balance":
                    Console.WriteLine(accountBalance);
                    break;
                default:
                    break;
            }
        }

        public void getAccountDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber + "\n");
            Console.WriteLine("Account Name: " + accountName +"\n");
            Console.WriteLine("Balance: " + accountBalance + "\n");
        }
    }
}