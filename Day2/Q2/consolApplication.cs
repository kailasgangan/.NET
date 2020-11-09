using System;
using ClassLibrary2;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1=new Class1();
            int k = int.Parse(Console.ReadLine());
            int g= c1.square(k);
            int g1 = c1.cube(k);
            Console.WriteLine("Square=" + g);
            Console.WriteLine("Cube=" + g1);
            Console.ReadLine();


        }
    }
}
