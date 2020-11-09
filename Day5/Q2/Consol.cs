using System;
using Day5Account;

namespace ConsoleDay5Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("kailas",1500);
            a1.display();
            Account a2 = new Account("Prath", 1500);
            a2.display();
            Account a3 = new Account("Ajay", 900);
            a3.display();
            Account a4 = new Account("neha", 1500);
            a4.display();
            Account a5 = new Account("chetna",2000);
            a5.display();

            a1.deposit(1000);
            a1.display();

            Console.ReadLine();

        }
    }
}
