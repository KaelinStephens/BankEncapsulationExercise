using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account1 = new BankAccount();
            
            do
            {

                Console.WriteLine("Would you like to deposit money or retrieve your balance?");
                var input = Console.ReadLine();
                if (input == "deposit money")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    var amount = double.Parse(Console.ReadLine());
                    BankAccount.Deposit(amount);
                    Console.WriteLine("Would you like to see your new account balance? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        BankAccount.GetBalance();
                       
                    }
                    else if (Console.ReadLine()== "exit")
                    {
                        break;
                    }
                   
                }
                else if (input == "retrieve balance")
                {
                    BankAccount.GetBalance();
                    
                }
                else if (input == "exit")
                {
                    break;
                }
            } while ( true);
        }
    }
}
