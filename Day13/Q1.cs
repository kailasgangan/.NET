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
        static int id = 0;
        private string name = null;
        private double balance = 0;
        const int obj = 3;
        static int objcnt = 0;
        public Account(string name, double bl)
        {
            Name = name;
            Balance = bl;
        }
        public string Name
        {
            set {
                if (value.Length <= 15)
                {
                    this.name = value;
                }
                else {
                    throw new Exception("name length should be less than 15 charactor");
                }
                
            }
            get {
                return this.name;
            }
        }
        public double Balance {
            set {
                    this.balance = value;
                
            }
            get {
                return this.balance;
            }
        }
        public void deposit(double dp)
        {
            this.balance += dp;
            Console.WriteLine("{0} amount is deposited", dp);
        }
        public void withdraw(double w)
        {
            if (this.balance - w >= 1000)
            {
                this.balance -= w;
                Console.WriteLine("{0} amount is withdraw ", w);
            }
            else {
                throw new Exception("minimum balance must be 1000");
            }
        }
        public void display()
        {
            Console.WriteLine("Id={0} ,name={1} and balance={2}", this.GeneratedId, this.name, this.balance);
        }
    }
    class demo
    {
        static void Main()
        {
            try
            {
                Account a1 = new Account("kailas",1500);
                //a1.withdraw(1000);
                Account a2 = new Account("kailas ekanath gangan", 1500);
            }
            catch(Exception ee){
                 Console.WriteLine(ee.Message);
            }
            Console.ReadLine();

        }
    }
}
