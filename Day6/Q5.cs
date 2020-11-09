using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static int cnt=0;
        static void Avarage(int[] x)
        {
            int sum=0;
            for (int i = 0; i < x.Length; i++)
               sum+=x[i];
            Console.WriteLine("Average="+sum/x.Length);
        }
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter array size");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
           
            for (i = 0; i < arr.Length; i++) {
                    arr[i] = int.Parse(Console.ReadLine());
            }
            Avarage(arr);
           
            Console.ReadLine();
        }
    }
}

