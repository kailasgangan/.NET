using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            string p1 = Console.ReadLine();
            Console.WriteLine("Confirm Password");
            string p2 = Console.ReadLine();

            if (object.Equals(p1,p2)) {//----------(p1.Equals(p2))-------(p1==p2)====true--if both strings are same
                Console.WriteLine("password correct");
            }
            else{
                Console.WriteLine("password incorrect");   
            }
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.ReadLine();
        }
    }
}
