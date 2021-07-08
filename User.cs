using System;
using System.Collections.Generic;

namespace ConsoleGame
{
    public class User
    {
        /**
            TODO:
                USER:
                    - Add DOB
                    - Add Address
                    - Add Phone
                    - Add Username and Password for Authentication
                    - Add keyphrase to reset Password
                    - Add a checker to ensure email is correct
        */

        public string firstName;
        private string lastName;
        private string emailAddress;
        public List<Accounts> accounts = new List<Accounts>();

        public User(string first, string last, string email)
        {
            firstName = first;
            lastName = last;
            emailAddress = email;
        }

        public double GetBalance(string userAccountName)
        {
            // Console.WriteLine(accounts.Find(account => account.accountName == userAccountName).accountBalance);
            return accounts.Find(account => account.accountName == userAccountName).accountBalance;
        }

        public void Deposit(string userAccountName, double amount)
        {
            Accounts receivingAccount = accounts.Find(account => account.accountName == userAccountName);
            receivingAccount.accountBalance += amount;
        }

        public void Deposit(int userAccountNumber, double amount)
        {
            try {
                Accounts receivingAccount = accounts.Find(account => account.accountNumber == userAccountNumber);
                receivingAccount.accountBalance += amount;
            }
            catch(NullReferenceException) {
                Console.WriteLine($"The account number '{userAccountNumber}' does not exist, please try another number\n");
            }
        }

        public void Withdrawal(string userAccountName, double amount)
        {
            Accounts receivingAccount = accounts.Find(account => account.accountName == userAccountName);
            receivingAccount.accountBalance -= amount;
        }

        public void createAccount(string name, double balance)
        {
            if (accounts.Count < 5)
            {
                Accounts newAccount =  new Accounts(name, balance);
                accounts.Add(newAccount);

                // newAccount.getAccountDetails();
            }
        }
    }
}