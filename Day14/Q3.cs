using System;

namespace ConsoleApplication9
{
    delegate int wd<T>(T x);
    static class math
    {
        public static int factorial(int a)
        {
            int fact = 0;
            for (int i = a; i > 0; i--)
            {
                if (i == a)
                {
                    fact = i;
                }
                else
                {
                    fact *= i;
                }
            }
            return fact;
        }
        public static int square(int a)
        {
            int r = a * a;
            return r;
        }
        public static int cube(int a)
        {
            int r = a * a;
            int r1 = r * a;
            return r1;
        }
    }
    class demo
    {
        public static void Main()
        {
            wd<int> matha = new wd<int>(math.factorial);
            matha += new wd<int>(math.cube);
            matha += new wd<int>(math.square);
            foreach (wd<int> m in matha.GetInvocationList())
            Console.WriteLine(m.Method + " " + m.Invoke(3));

            Console.ReadLine();
        }
    }
}
