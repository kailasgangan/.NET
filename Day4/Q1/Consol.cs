using System;
using ClassLibraryAccount;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(1,"kailas");
            Account a1 = new Account(2, "prath");
            Console.Write("Enter your id=");
            a.deposite(20000);
            a1.deposite(25000);
            a.display();
            a1.display();
            a.withdraw(1000);
            a1.withdraw(15000);
            a.display();
            a1.display();
            Console.ReadLine();
        }
    }
}
