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
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                for(int k=i-1;k>0 ; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
