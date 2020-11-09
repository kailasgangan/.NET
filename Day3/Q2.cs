using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    struct Math {
        public static void factor(int a) {
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
       
       
    }
    public class class1{

       public static void Main(){
           int a=int.Parse(Console.ReadLine());
           Math.factor(a);
           Console.ReadLine();
        
       }
    }
}
/*
 257
1
*/
