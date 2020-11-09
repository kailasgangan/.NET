using System;

namespace ConsoleSharedApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Type" + k.GetType() + "\n Base Type" + k.GetType().BaseType);

            Console.ReadLine();

        }
    }
}
