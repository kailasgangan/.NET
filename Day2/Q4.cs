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
            if (n1 < 0) {
                Console.WriteLine("not valid no");
            }
            else if (n1 == 0) {
                Console.WriteLine("square of 0 = 0");
            }
            else if (n1 == 1) {
                Console.WriteLine("square of 1 = 1");
            }
            else if (n1 <= 2) {
                Console.WriteLine("square of {0} = "+n1 * n1,n1);
            }

            Console.ReadLine();
        }
    }
}
