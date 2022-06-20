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

        public static void Kangaroo(int x1, int v1, int x2, int v2)
        {
            int i=0;
            int k1Pos = x1;
            int k2Pos = x2;
            bool meeting = false;
            while(!meeting && i<1000){
                if(x1 == x2)
                {
                    meeting = true;
                    break;
                }
                x1 += v1;
                x2 += v2;
                i++;
            }
            if(meeting)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
