using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class longIntAdd
    {
        public void addLongInt()
        {
            long[] a = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long add = 0;
            for (int i = 0; i < a.Count(); i++)
            {
                add += a[i];
            }
            Console.WriteLine(add);
            Console.ReadLine();
        }
    }
}
