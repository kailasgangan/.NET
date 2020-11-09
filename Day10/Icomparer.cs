using System;
using System.Collections;

namespace ConsoleApplication14
{
    abstract class Account
    {
        private int Id;
        static int genID = 0;
        private string _name;
        private double _balanceamt;
        public abstract void withdraw(double amt);

        public double Balanceamt
        {
            set
            {
                _balanceamt = value;
            }
            protected get
            {
                return _balanceamt;
            }
        }
        public string Name
        {
            set
            {
                if (value.Length < 3)
                    throw new Exception("name length is < 3");
                else
                    _name = value;

            }
            get
            {
                return _name;
            }
        }
        public void deposit(double amt)
        {
            _balanceamt += amt;
        }
    }
    class saving : Account
    {
        public saving(string nm, double amt)
        {
            if (amt >= 1000)
            {
                Name = nm;
                Balanceamt = amt;
                return;
            }
            Console.WriteLine("saving account open with min balance 1000");

        }
        public override void withdraw(double amt)
        {
            if ((Balanceamt - amt) >= 1000)
            {
                Balanceamt -= amt;
                return;
            }
            Console.WriteLine("cant withdraw min balance should be 1000");
            return;

        }
        public override string ToString()
        {
            return ("This is saving Account :name=" + Name + " and " + "balance=" + Balanceamt);
        }
    }
    class current : Account
    {
        public current(string nm, double amt)
        {
            Name = nm;
            Balanceamt = amt;
        }
        public override void withdraw(double amt)
        {
            Balanceamt -= amt;
        }
        public override string ToString()
        {
            return ("This is Current Account :name=" + Name + " and " + "balance=" + Balanceamt);
        }
    }
    class Data_sort : IComparer
    {
        public int Compare(object x, object y)
        {

            Account t1 = x as Account;
            Account t2 = y as Account;
            if (t1 != null && t2 != null)
                return String.Compare(t1.Name, t2.Name);
            else
                throw new ArgumentException("Parameter is not a Emp!");

        }
    }
    static class Program
    {
        static Program()
        {
            Console.WriteLine("Bank Of India:");
        }
        static void Main(string[] args)
        {
            Account[] a1 = new Account[3];
            a1[0] = new saving("kailas", 10000);
            a1[1] = new current("prath", 0);
            a1[2] = new saving("ajay", 500);

            Array.Sort(a1, new Data_sort());

            foreach (Account e in a1)
                Console.WriteLine("name={0}",e.Name);

            Console.ReadLine();;
        }
    }
}
