using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Result
    {
        public static void miniMaxSum(List<int> arr)
        {
            int i, j;
            long sum = 0;
            List<long> result = new List<long>();
            for (i = 0; i < arr.Count; i++)
            {
                for (j = 0; j < arr.Count; j++)
                {
                    sum += arr[j];
                }
                sum -= arr[i];
                result.Add(sum);
                sum = 0;
            }
            Console.WriteLine(result.Min() + " " + result.Max());
            Console.ReadLine();
        }
    }
}
