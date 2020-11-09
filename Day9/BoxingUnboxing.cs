using System;

namespace ConsoleApplication15
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int i;
            bool s=int.TryParse(Console.ReadLine(),out i);
            object o = i;      // Boxing copies the value of i into object o.
            int x = (int)o;   //unboxing

            Console.WriteLine("Boxing=" + o);
            Console.WriteLine("unboxing=" + x);
            Console.ReadLine();
        }
    }
}
