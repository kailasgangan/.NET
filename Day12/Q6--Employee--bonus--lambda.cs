using System;
delegate void emp(double sal, string name, double bonus);
namespace ConsoleApplication15
{
    abstract class Employee
    {
        public event emp employee;
        private int Accid;
        static int id;
        public abstract double givebonus();
        public string _name { set; get; }
        public double _salary { set; get; }

        public Employee(String name, double sal)
        {
            Accid = ++id;
            Name = name;
            Salary = sal;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Salary
        {
            get { return _salary; }
            protected set { _salary = value; }
        }


        public void Ongivebonus(double sal, string name, double bonus)
        {
            if (employee != null)
                employee(sal, name, bonus);
        }
    }
    class Permanente : Employee
    {
        public Permanente(String name, Double sal)
            : base(name, sal) { }

        public override double givebonus()
        {
            double d = (50 * Salary) / 100;
            Ongivebonus(Salary, Name, d);
            return d;
        }
    }
    class temporary : Employee
    {
        public temporary(String name, Double sal)
            : base(name, sal) { }

        public override double givebonus()
        {
            double d = (40 * Salary) / 100;
            Ongivebonus(Salary, Name, d);
            return d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp1 = new Employee[2];
            emp1[0] = new Permanente("kailas", 50000);
            emp1[1] = new temporary("prath", 6000);

            for (int i = 0; i < emp1.Length; i++)
            {
                emp1[i].employee += (double sal, string name, double bonus) => Console.WriteLine("message send....salry={0} name={1} bonus={2}", sal, name, bonus);
            }

            double d1 = emp1[0].givebonus();
            double d2 = emp1[1].givebonus();


            Console.ReadLine();
        }
    }
}
