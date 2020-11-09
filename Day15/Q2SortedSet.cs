using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class sorting
    {
        public static void Main(){
        int[] a = { 1, 2, 1, 3, 4, 2 };
        HashSet<int> hashint = new HashSet<int>();
        for (int i = 0; i < a.Length; i++) {
            hashint.Add(a[i]);
        }
        foreach (var v in hashint)
            Console.WriteLine(v);

        Console.ReadKey();
    }
    }

}
        
