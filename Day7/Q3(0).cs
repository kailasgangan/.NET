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
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            Console.WriteLine("Enter Array:");
            for (int i = 0; i < arr1.Length; i++) {
                arr1[i] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("");
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = arr1[i];
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine("Array 1={0} Array2={1}",arr2[i],arr1[i]);
                }
                Console.ReadLine();
        }
    }
}
