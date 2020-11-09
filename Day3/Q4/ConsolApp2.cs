using System;
using ClassShared;

namespace ConsoleSharedApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
             Console.WriteLine("Enter no for sum and product");
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter no for cube");
            double d3=double.Parse(Console.ReadLine());
            double d = c.sum(d1, d2);
            double e = c.product(d1, d1);
            double f = c.Cube(d3);
            Console.WriteLine("sum=" + d);
            Console.WriteLine("Product=" + e);
            Console.WriteLine("cube=" + d3);
            Console.ReadLine();

        }
    }
}
