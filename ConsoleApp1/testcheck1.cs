using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class testcheck1
    {
        public static void main(string[] args)
        {
            int i, j, k=1;
            for(i=1;i<5;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(k+++" ");
                }
                Console.WriteLine();      
            }
          
        }
    }
}
