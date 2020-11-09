using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
  
            int n1 = int.Parse(Console.ReadLine());
            checked {
                byte b = (byte)n1;
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}

