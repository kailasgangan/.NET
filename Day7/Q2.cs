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
            int size;
            while (!int.TryParse(Console.ReadLine(), out size)){
                Console.WriteLine("enter a size again int integer");
            }
            int[] arr = new int[size];
            Console.WriteLine("Enter Array:");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
                Console.WriteLine("Sorted Array in Descending:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                Console.ReadLine();
        }
    }
}
