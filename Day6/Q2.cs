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
        static void Main(string[] args)
        {
            int i, j,sum=0;
            Console.WriteLine("enter r and column");
            int r=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            int[,] mtx = new int[r, c];
            for (i = 0; i < r; i++) {
                for (j = 0; j < c; j++) {
                    mtx[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //----------------printing row wise sum-------------------
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                   
                    sum += mtx[j, i];
                }
                ++cnt;
                Console.WriteLine("sum of {0} row={1}",cnt,sum);
                sum = 0;
            }
            Console.ReadLine();
        }
    }
}
