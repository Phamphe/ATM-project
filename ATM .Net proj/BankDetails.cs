using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone
{
    public class BankDetails
    {
        public string accountNum;
        public int pin;
        public string firstName;
        public string lastName;
        public double balance;

        public BankDetails (string accountNum, int pin, string firstName, string lastName, double balance)
        {
            this.accountNum = accountNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        {
            return accountNum;
        }

        public int getPin()
        {
            return pin;
        }
        public string getfirstName()
        {
            return firstName;
        }
        public string getlastName()
        {
            return lastName;
        }

        public double getBalance( )
        {
            return balance;
        }

        public void setNum(string newAccountNum)
        {
            accountNum = newAccountNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;   
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }
         
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

    }
}
