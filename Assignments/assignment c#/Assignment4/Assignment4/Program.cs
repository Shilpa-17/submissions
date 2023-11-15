using System;
using static System.Console;

namespace assignment4
{
    class quea
    {
        static void Main(string[] args)
        {

            WriteLine("account details");
            WriteLine("account number:");
            int accountNo = Convert.ToInt32(ReadLine());
            WriteLine("user name:");
            string name = ReadLine();
            WriteLine("account type:");
            string AccountType = ReadLine();
            WriteLine("amount:");
            int amount = Convert.ToInt32(ReadLine());
            WriteLine("balance:");
            int balance = Convert.ToInt32(ReadLine());
            WriteLine("transaction type:");
            WriteLine("D-deposite/W-withdraw:");
            string TransactionType = ReadLine();



            if (TransactionType == "D")
            {
                WriteLine("deposite");
            }
            else if (TransactionType == "W")
            {
                WriteLine("withdraw");

            }
            if (amount > balance)
            {
                balance += amount;

                TransactionType = "D"; // Deposit

                balance += amount;

            }

            else

            {

                WriteLine("Invalid deposit amount.");

            }
            {

                if (balance > amount)

                {

                    balance -= amount;

                    TransactionType = "W"; // Withdrawal

                    balance += amount;
                    WriteLine("transaction processed");
                }

                else

                {

                    WriteLine("Invalid withdrawal amount or insufficient balance.");

                }

            }

            {
                WriteLine("account number: " + accountNo);
                WriteLine("user name: " + name);
                WriteLine("account type: " + AccountType);
                WriteLine("transaction type: " + TransactionType);
                WriteLine("amount: " + amount);
                WriteLine("balance: " + balance);
            }


        }
    }

}


