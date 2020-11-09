using System;

namespace ConsoleApplication9
{
    delegate int wd(int x);
    class math{
    public int factorial(int a){
        int fact=0;
        for (int i = a; i > 0;i--){
            if (i == a)
            {
                fact = i;
            }
            else {
                fact *= i;
            }
        }
        return fact;
    }
	public int square(int a){
        int r= a * a;
        return r;
    }
     public int cube(int a){
         int r=a * a;
         int r1 = r * a;
         return r1;
    }
    }
    class demo {
        public static void Main() {
            math math = new math();//-----------create instance of math class

            wd matha = new wd(math.factorial);//---------assign handler by instance
            matha += new wd(math.cube);
            matha += new wd(math.square);
            foreach (wd m in matha.GetInvocationList())
                Console.WriteLine(m.Method+" "+m.Invoke(3));

                Console.ReadLine();
            }
           
        }
    }
