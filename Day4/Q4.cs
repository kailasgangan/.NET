using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Printer {
        static Printer p=null;
        string ptr;
        private Printer(string ptr1) {
            ptr = ptr1;
            Console.WriteLine("in private constructor");
        }
        public static Printer getref(){
            if (p == null)
            {
                p = new Printer("printer");
            }
            return p;
        
        }
        public void printing(){

            Console.WriteLine(ptr);
        }
        static void Main(string[] args)
        {
            Printer p1=getref();
            p1.printing();
            Printer p2 = getref();
            p2.printing();
            Console.ReadLine();


        }
    }
}
