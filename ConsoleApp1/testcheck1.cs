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
            int[] a = { 1, 0, 1 };
            int[] b = { 0, 1, 0 };
            int alice = 0, bob = 0;
            int count = a.Count();
            for (int i = 0; i < count; i++)
            {
                if (a[i] > b[i])
                {
                    alice = alice + 1;
                }
                else
                {
                    bob = bob + 1;
                }
            }
            Console.WriteLine(alice +" "+ bob);
            Console.ReadLine();
         }
    }
}
