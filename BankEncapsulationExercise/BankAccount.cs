using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
   {
        public BankAccount()
        {
            Balance = 0;
        }
        private static double Balance { get; set; }

        public static void  Deposit(double deposit)
        {
            BankAccount.Balance = deposit + BankAccount.Balance;
        }
        public static double GetBalance()
        {
           
            return BankAccount.Balance;
        }
    }
}
