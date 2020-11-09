using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysort
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2=s1.ToLower();
            if (s1 == s2)//---------------checks value---string class overrides ==operator 
            {
                Console.WriteLine("strings are equals by ==");
            }
            else
            {
                Console.WriteLine("string are not equals by ==");
            }
            if (s1.Equals(s2))//-----------checks value string class overrides Equals method
            {
                Console.WriteLine("strings are equals by virtual Equal methods");
            }
            else
            {
                Console.WriteLine("string are not equals by virtual Equal methods");
            }
                Console.ReadLine();
        }
    }
}
