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
            List<int> ar = new List<int>();
            ar.Add(10); ar.Add(20); ar.Add(20); ar.Add(10); ar.Add(10); ar.Add(30); ar.Add(50); ar.Add(10); ar.Add(20);
            int n = 9;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (ar[i] == ar[j])
                        {
                            n -= 2;
                            count++;
                            ar.Remove(ar[i]);
                            ar.Remove(ar[j]);
                        }
                    }
                }
            }
            Console.WriteLine(count);
             Console.ReadLine();
        }
    }
}
