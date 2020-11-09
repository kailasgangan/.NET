using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication26
{
   class sorting
    {
        /*public static void startwith(this string imp) {
            if (imp.StartsWith("v")) {
                return imp;
            }
        }
*/
        public static void Main(string[] args){
            string[] str = {"vita", "vidya", "dac", "edac","dbda" };
                        IEnumerable<string> subset = from g in str
                                         where g.StartsWith("v")
                                         orderby g
                                         select g;
                        foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);

           Console.ReadKey();
            }
   }
}
          

         
          
             
