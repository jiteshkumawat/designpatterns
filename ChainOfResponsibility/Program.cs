using System;
namespace DesignPatterns.ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("\n Requested Amount 4600");
            atm.Withdraw(4600);
            Console.WriteLine("\n Requested Amount 1900");
            atm.Withdraw(1900);
            Console.WriteLine("\n Requested Amount 600");
            atm.Withdraw(600);
            Console.Read();
        }
    }
}