using System;

namespace ConsoleApplication9
{
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
        public static bool boolean(bool b) {
            return b;
        }
    }
    class demo
    {
        public static void Main()
        {
            Func<int, int> fun = new Func<int, int>(math.factorial);
            fun += math.cube;
            fun += math.square;
            foreach(Func<int,int> x in fun.GetInvocationList()){
                Console.WriteLine("method="+x.Method+"value="+x.Invoke(5));
            }

            Predicate<bool> prct = new Predicate<bool>(math.boolean);
            Console.WriteLine(prct(true));

            Console.ReadLine();
        }
    }
}
