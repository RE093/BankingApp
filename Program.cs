using System;
using System.Collections.Generic;

namespace ConsoleGame
{
    class Program
    {
        /**
            TODO:
                Accounts:
                    - account types ~ types give different interest over time
                        - better interest means fixed terms and penalties
                    - Account number generation prevents duplication
                    - Edit account details functionality
                
                User:
                    - Add payees
                    - Remove payees
                    - Remove accounts
                    - Add authentication
        */

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Welcome to the banking app! \n\n");
            
            List<User> users = new List<User>(); 
            var user1 = new User("Jack", "Peterson", "je@gmail.com");
            var user2 = new User("Alli", "Marks", "ae@gmail.com");

            // Create users
            users.Add(user1);
            users.Add(user2);

            // Creating user accounts
            user1.createAccount("JEeveryday", 100);
            user1.createAccount("JEsavings", 1000);
            user2.createAccount("AEeveryday", 110);
            
            // Internal Transaction
            var transactionOne = new Transactions(user1);
            transactionOne.transferMoney("JEeveryday", "JEsavings", 300);

            // External Transaction
            var transactionTwo = new Transactions(user1, user2);
            transactionTwo.PayAnotherUser("AEeveryday", "JEeveryday", 30);
        }
    }
}
