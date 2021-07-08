namespace ConsoleGame
{
    /**
        TODO:
            - Remove duplication of transfer function
            - Add database so account numbers don't change on initialization
    */

    public class Transactions
    {
        private User sendingUser;
        private User receivingUser;

        public Transactions(User sender, User receiver)
        {
            sendingUser = sender;
            receivingUser = receiver;
        }

        public Transactions(User sender)
        {
            sendingUser = sender;
        }

        public string transferMoney( string accountNameTo, string accountNameFrom, double amount)
        {
            double sendingAccountBalance =  sendingUser.GetBalance(accountNameFrom);

            if (sendingAccountBalance >= amount)
            {
                sendingUser.Withdrawal(accountNameFrom, amount);
                sendingUser.Deposit(accountNameTo, amount);

                return "transferred";
            }
            return "Not enough money in your account to transfer";
        }

        public string PayAnotherUser(string accountNameTo, string accountNameFrom, double amount)
        {   
            double sendingAccountBalance = sendingUser.GetBalance(accountNameFrom);

            // get account number from bank account name - TEMP -->
            int receivingAccountNumber = receivingUser.accounts.Find(account => account.accountName == accountNameTo).accountNumber;

            if (sendingAccountBalance >= amount)
            {
                sendingUser.Withdrawal(accountNameFrom, amount);
                receivingUser.Deposit(receivingAccountNumber, amount);

                return "Payment sent successfully";

            }
            return "Payment unsuccessful, please check your account balance";
        }
    }
}