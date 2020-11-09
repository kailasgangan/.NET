using System;
using System.Collections.Generic;
namespace ConsoleApplication26
{
    class sorting
    {
        public static void Main(){
        int[] a = { 1, 2, 1, 3, 4, 2 };
        HashSet<int> listint = new HashSet<int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                listint.Add(a[i]);
            }
        }
        foreach (int x in listint)
            Console.WriteLine(x);

            Console.ReadKey();
    }
    }

}
        
