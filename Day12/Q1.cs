using System;
public delegate int wd(int x);
namespace ConsoleApplication9
{
    public class anno
    {
        wd fact = delegate(int a)
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
        };
        wd sqr = delegate(int a)
        {
            return a * a;
        };
        wd cube = delegate(int a)
        {
            int r = a * a;
            int r1 = r * a;
            return r1;
        };
        public static void Main()
        {
            anno a = new anno();
            wd evt = a.fact;
            evt += a.sqr;
            evt += a.cube;
            foreach (wd m in evt.GetInvocationList())
                Console.WriteLine(m.Method + " " + m.Invoke(3));

            Console.ReadLine();
        }
    }
}