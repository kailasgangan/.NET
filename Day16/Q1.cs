using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication27
{
    class Employee { 
    public int Id{set;get;}
    static int genID;
        public string Name{get; set;}
        public double salary{set;get;}
        public string Address{set;get;}
        public Employee(string nm,double sal,string addss) {
            Id = ++genID;
            Name = nm;
            salary = sal;
            Address = addss;
        }
        public override string ToString() {
            return string.Format("ID="+Id+"Name="+Name+"salary="+salary+"Address="+Address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("kailas", 25000, "Andheri");
            Employee e2 = new Employee("prath", 27000, "Kandivali");
            Employee e3 = new Employee("ajay", 256700, "Vile parle");
            List<Employee> lst = new List<Employee>();
            lst.Add(e1);
            lst.Add(e2);
            lst.Add(e3);
            Console.WriteLine("\n - Display all employee detail");
            var query = from r in lst select r;//--------------. Display all employee detail
            foreach (var x in query)
            {
                               Console.WriteLine(x);
            }
            Console.WriteLine("\n  Display all employee who are staying at Andheri");
            var query1 = from r in lst where r.Address.Contains("Andheri") select r;//------------. Display all employee who are staying at Andheri
            foreach (var x in query1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n -Display total of all salary");
            var query2 = (from r in lst select r.salary).Sum(); ;//-----------Display total of all salary
            Console.WriteLine(query2);

            Console.WriteLine("\n   Display  all employee who’s name start with v");
            var query3 = from r in lst where r.Address.Contains('V') select r;//------------. Display  all employee who’s name start with v
            foreach (var x in query3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n   Count number of Employee in a company");
            var query4 = (from r in lst select r).Count() ;//------------Count number of Employee in a company
            Console.WriteLine(query4);

            Console.WriteLine("\n   Display all employee getting salary > 50000");
            var query5 = from r in lst where r.salary> 50000 select r;
            foreach (var x in query5)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n   g. Display min , max and average salary");
            var query6 = (from r in lst select r.salary).Min();
            Console.WriteLine("minimum="+query6);
            var query61 = (from r in lst select r.salary).Max();
            Console.WriteLine("maximun=" + query61);
            var query62 = (from r in lst select r.salary).Average();
            Console.WriteLine("Average=" + query62);

            Console.WriteLine("\n  h. Display all name in ascending order");
            var query7 = from r in lst orderby r.Name select r;
            foreach (var x in query7)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n  h. i. display all record salary in descending order salary wise");
            var query8 = from r in lst orderby r.salary descending select r;
            foreach (var x in query8)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n  h. display Id and name who’s salary is <20000");
            var query9 = from r in lst where r.salary>20000 select r;
            foreach (var x in query9)
            {
                Console.WriteLine(x.Id+" "+x.Name);
            }

            


            Console.ReadKey();
        }
    }
}
