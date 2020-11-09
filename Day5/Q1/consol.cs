using System;
using Day5Employee;

namespace ConsolDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("kailas", "ekanath", "gangan");
            Employee e2 = new Employee("prath", "sawant");
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.ReadLine();
        }
    }
}
