using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Account
{
    public class Account 
    {
        private int GeneratedId = 0;
        static int id=0;
        private string name=null;
        private double balance=0;
        const int obj = 3;
        static int objcnt = 0;
        public Account(string name,double bl)
        {
            if(bl >= 1000)
            {

                ++objcnt;
                if (objcnt <= obj)
                {
                    this.GeneratedId = ++id;
                    this.name = name;
                    this.balance = bl;
                }
                else
                {
                    Console.WriteLine("object is not created were name is {0}",name);
                }
            }
            else {
                Console.WriteLine("min bal amount should be 1000");
            }
        }
        public void deposit(double dp) { 
        this.balance += dp;
        Console.WriteLine("{0} amount is deposited", dp);
        }
        public void withdraw(double w) {
            this.balance -= w;
            Console.WriteLine("{0} amount is withdraw ", w);
        }
        public void display() {
            Console.WriteLine("Id={0} ,name={1} and balance={2}",this.GeneratedId, this.name, this.balance);
        } 
    }
}
