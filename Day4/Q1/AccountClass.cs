using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAccount
{
    class Account
    {
        private int id;
        private string name;
        private double balance = 0;

        public void deposite(double deposite)
        {
            this.balance += deposite;
        }
        public void withdraw(double wdr)
        {
            this.balance -= wdr;
        }
        public void display()
        {
            Console.WriteLine("Name=" + this.name + "  Balance=" + this.balance);
        }
        public Account(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
