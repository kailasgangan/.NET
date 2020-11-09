using System;
using Day5Employee2classLibrary;

namespace ConsoleDay5Employee2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("kailas", 40000);
            e1.calculate_netsalary();
            e1.display();
            Employee e2 = new Employee("prath", 45000);           
            e2.calculate_netsalary();
            e2.display();
            Employee e3 = new Employee("ajay", 60000);
            Console.ReadLine();
        }
    }
}
