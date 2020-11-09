using System;
using System.Threading;
namespace ConsoleApplication27
{
    class Employee {

        public static void PrintNo() {
            for (int i = 0; i < 10; i++) {
                Thread.Sleep(200);
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thread mythrd = new Thread(new ThreadStart(Employee.PrintNo));
            mythrd.Name = "first";
            mythrd.Start();
            Thread mythrd1 = new Thread(new ThreadStart(Employee.PrintNo));
            mythrd1.Name = "second";
            mythrd1.Start();

            Console.ReadKey();
        }
    }
}
