using System;

namespace ConsoleApplication15
{
   public  interface Itaxtogov {
       void paytax(double amt); 
   }
    class myindia:Itaxtogov {
        public void paytax(double amt) {
            double d = (40 * amt) / 100;
            Console.WriteLine("Tax in India="+d);
        }
    }
    class myeurope:Itaxtogov {
        public void paytax(double amt)
        {
            double d = (30 * amt) / 100;
            Console.WriteLine("Tax in urope=" + d);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Itaxtogov[] tax = new Itaxtogov[2];
            tax[0] = new myindia();
            tax[1] = new myeurope();

            for (int i = 0; i < tax.Length; i++) {
                tax[i].paytax(10000);
            }
                Console.ReadLine();
        }
    }
}
