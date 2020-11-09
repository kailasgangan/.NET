using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class calculator 
    {
        public static void square(double d) {
            Console.WriteLine("square="+d*d);
        }
        public static void cube(double d)
        {
            double k = d * d;
            Console.WriteLine("cube="+k * d);

        }
        public static void absolute(double d)
        {
            Console.WriteLine("absolute="+Math.Abs(d));
        }
        public static void floor(double d) {
           Console.WriteLine("Floor="+Math.Floor(d));
        }
        public static void ceiling(double d) {
            Console.WriteLine("ceiling="+Math.Ceiling(d));
        }
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            square(d);
            cube(d);
            absolute(d);
            floor(d);
            ceiling(d);
            Console.ReadLine();
        }
    }
}
