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
        static void square(int[] x,int[] x1)
        {
            for (int i = 0; i < x.Length; i++)
               x1[i] = x[i] * x[i] ;
        }
        static void Main(string[] args)
        {
            int i,sum=0;
            Console.WriteLine("enter array size");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2 = new int[size];
            for (i = 0; i < arr.Length; i++) {
                    arr[i] = int.Parse(Console.ReadLine());
            }

            //----------------printing row wise sum-------------------
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("sum="+sum);
            square(arr,arr2);
            Console.WriteLine("Array 2=");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadLine();
        }
    }
}

