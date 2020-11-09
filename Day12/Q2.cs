using System;
delegate int wd(int x);
namespace ConsoleApplication9
{
   
    class demo
    {
        public static void Main()
        {
            wd matha = a =>
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

            matha += a =>
            {
                int r = a * a;
                int r1 = r * a;
                return r1;
            };
            matha += a => a * a;
            foreach (wd m in matha.GetInvocationList())
                Console.WriteLine(m.Method + " " + m.Invoke(3));

            Console.ReadLine();
        }

    }
}
