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
                if (Console.ReadLine() == "deposit money")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    BankAccount.Deposit(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Would you like to see your new account balance? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        Console.WriteLine(BankAccount.GetBalance());
                       
                    }
                    else if (Console.ReadLine()== "exit")
                    {
                        break;
                    }
                   
                }
                else if (Console.ReadLine() == "retrieve balance")
                {
                    Console.WriteLine(BankAccount.GetBalance());
                    
                }
                else if (Console.ReadLine() == "exit")
                {
                    break;
                }
            } while ( true);
        }
    }
}
