using System;
using ClassShared;


namespace ConsoleSharedAss
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Double d1=double.Parse(Console.ReadLine());
            Double d2=double.Parse(Console.ReadLine());
            double d=c.sum(d1, d2);
            double e= (double)c.product(d1, d1);
            Console.WriteLine("sum="+d);
            Console.WriteLine("Product=" + e);
            Console.ReadLine();
        }
    }
}
