using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
           
            Console.WriteLine("Please enter your desired deposit amount");

            var amountToDeposit = double.Parse(Console.ReadLine());
            
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Please see your balance.  Your balance is {account.GetBalance()}");


            Console.ReadLine();
            

        }

    }
}




