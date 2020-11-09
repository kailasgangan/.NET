using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    struct Math {
        public static int square(int a) {
            return a * a;
        }
        public static int Cube(int a)
        {
            int k=a * a;
            int k1 = k * a;
            return k1;
        }
       
    }
    public class class1{

       public static void Main(){
           int a=int.Parse(Console.ReadLine());
           
           int k=Math.square(a);
           int k1 = Math.Cube(a);

           Console.WriteLine("square of {0}="+k+"\n cube of {0}="+k1,a);
  

           Console.ReadLine();
        
       }
    }
}
/*
 257
1
*/
