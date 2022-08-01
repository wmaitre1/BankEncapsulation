using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        //for my reference. this is encapsulation
       public void Deposit(double amount)
        {
            balance = amount;
        }

        //this how you define a method. important to remember
        public double GetBalance()
        {
            return balance;
        }
    }



}
