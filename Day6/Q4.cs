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
        static void cube(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
               x[i] = x[i] * x[i] *x[i];
        }
        static void Main(string[] args)
        {
            int i,sum=0;
            Console.WriteLine("enter array size");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
           
            for (i = 0; i < arr.Length; i++) {
                    arr[i] = int.Parse(Console.ReadLine());
            }
            cube(arr);
            Console.WriteLine("Array after modifying");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}

