using System;
using Day5Account;
namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] a1=new Account[3];
            a1[0] = new Account("kailas",15000);
            a1[1] = new Account("Prath", 2500);
            a1[2] = new Account("Ajay", 5500);
            for (int i = 0; i < a1.Length; i++) {
                a1[i].display();
            }
                Console.ReadLine();
        }
    }
}
