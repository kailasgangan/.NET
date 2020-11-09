using System;

namespace Q3
{
    class demomaths 
    {
        public static void Square(float a)
        {
            float sqr = a*a;
            Console.WriteLine("Square="+sqr);
        }
        public static void cube(float a)
        {
            float cube = a * a * a;
            Console.WriteLine("cube="+cube);

        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            float a1 = float.Parse(a);
            demomaths.Square(a1);
            demomaths.cube(a1);
            Console.ReadLine();
        }
    }
}
