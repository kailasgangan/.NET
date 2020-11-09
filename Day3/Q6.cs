using System;

namespace ConsoleSharedApp1
{
    class Program
    {
        private int salary;
    }
    class Demo {
        public static void Main(string[] arg) {
            Program p = new Program();
            Console.WriteLine("Data Type="+p.GetType());
            Console.WriteLine("parent class name="+p.GetType().BaseType);
            Console.ReadLine();
        }
    }
}
