using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
   {
        public BankAccount()
        {
         
        }
        private static double balance;

        public  static void Deposit(double deposit)
        {
           balance += deposit;
        }
        public static void  GetBalance()
        {
           
            Console.WriteLine(balance);
        }
    }
}
