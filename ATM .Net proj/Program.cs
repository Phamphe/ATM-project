using ATM_clone;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Bank
{

    class Program
    {

        public static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from the following options: ");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");
            }

            void deposit(BankDetails currentUser)
            {
                Console.WriteLine("How much would you like to deposit");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);

                Console.WriteLine("Thank you for your deposit, Your new balance is: " + currentUser.getBalance() + "$");

            }

            void withdraw(BankDetails currentUser)
            {
                Console.WriteLine("How much would you like to withdraw");
                double withdraw = Double.Parse(Console.ReadLine());

                if (currentUser.getBalance() < withdraw)
                {
                    Console.WriteLine("You have insufficient money to make the transaction");
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdraw);
                    Console.WriteLine("You are good to go, Take your cash :)");
                }



            }

            void balance(BankDetails currentUser)
            {
                Console.WriteLine("Current balance available is: " + currentUser.getBalance());
            }

            List<BankDetails> bankDetails = new List<BankDetails>();
            bankDetails.Add(new BankDetails("4532772818527394", 1234, "Mulalo", "Phamphe", 1150.321));
            bankDetails.Add(new BankDetails("4532772818527395", 1235, "Pfunzo", "Mudau", 10050.321));
            bankDetails.Add(new BankDetails("4532772818527396", 1236, "Saakina", "Kafu", 2150.321));
            bankDetails.Add(new BankDetails("4532772818527397", 1237, "Takie", "Phamphe", 150.321));
            bankDetails.Add(new BankDetails("4532772818527398", 1238, "Betty", "Phamphe", 3000.321));


            Console.WriteLine("Welcome to our ATM, Press Enter to continue:");
            Console.ReadKey();
            Console.WriteLine("Enter your card Number: ");

            string debitCardNum = "";
            BankDetails currentUser;

            while (true)
            {
                try
                {

                    debitCardNum = Console.ReadLine();
                    currentUser = bankDetails.FirstOrDefault(a => a.accountNum == debitCardNum);

                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please try again");
                    }

                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }

            Console.WriteLine("Please Enter your pin:");

            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (userPin == currentUser.getPin())
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please try again");
                    }

                }
                catch
                { Console.WriteLine("Card not recognized. Please try again"); }
            }

            Console.WriteLine("Welcome " + currentUser.getfirstName() + " " + currentUser.getlastName());

            int option = 0;

            do
            {
                printOptions();

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {

                }

                if (option == 1)
                {
                    deposit(currentUser);
                }

                else if (option == 2)
                {
                    withdraw(currentUser);
                }
                else if (option == 3)
                {
                    balance(currentUser);
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    option = 0;
                }
            } while (option != 4);

            Console.WriteLine("Thank you!!");
        }
    }

    
}
