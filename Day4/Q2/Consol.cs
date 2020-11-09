using System;
using ClassLibraryEmployee;

namespace ConsoleApplicationEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1,"kailas",50000);
            Employee e2 = new Employee(2, "Prathamesh", 60000);
            int s1 = e1.netsalary();
            int s2 = e2.netsalary();
            e1.display();
            e2.display();
            Console.ReadLine();


        }
    }
}
