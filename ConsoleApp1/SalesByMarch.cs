using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SalesByMarch
    {
        public static void salemarch()
        {
            List<int> ar = new List<int>();
            ar.Add(1); ar.Add(2); ar.Add(3); ar.Add(4); ar.Add(1); ar.Add(2); ar.Add(3); ar.Add(4); ar.Add(1); ar.Add(2);
            int n = 10,RepeatCount = 0, max = 0;
            Console.WriteLine("max =" +max);
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == max)
                {
                    continue;                         //continue is used to skip the below steps and return to the above for loop
                }
                for (int j = 0; j < n; j++)
                {
                    if (i != j)                       //checking i is not equal to j
                    {
                        if (ar[i] == ar[j])           //checking two numbers are equal
                        {
                            ar[i] = max; ar[j] = max; //replacing same numbers found with zero
                            RepeatCount++;break;      //counting and breaking the for loop of j
                        }
                    }

                }
            }
            Console.WriteLine("Repeat = " + RepeatCount);
            Console.WriteLine("loop");
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }

        }
    }
}
