using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class testcheck1
    {
        public  void testcheck()
        {
            int add1 = 0;
            int add2 = 0;
            int[,] ar = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i =0; i < ar.GetLength(0); i++)
            {
                add1 += ar[i, i];
            }
            //------------------
            int k = 0;
            for(int j=(ar.GetLength(0)-1);j>=0;j--)
            {
                add2 += ar[j,k];
                k++;
            }

            Console.WriteLine(add1);
            Console.WriteLine(add2);
            Console.ReadLine();
        }
    }
}
