using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            byte b = 20;
            int sum1 = a + b;
            byte sum2 = (byte)(a+b);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.ReadLine();
        }
    }
}

