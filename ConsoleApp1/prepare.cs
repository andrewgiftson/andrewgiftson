using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class prepare
    {
        public static void Main(string[] args)
        {
            int n = 5;
            int k = 1;
            for (int i = 0;i < n; i++)
            {                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(k+++" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
