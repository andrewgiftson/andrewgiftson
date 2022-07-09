using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FizzBuzz { 
    public static void fizzBuzz(int n)
    {
        List<int> num = new List<int>();
        int val = 0, div3 = 0, div5 = 0;
        for (int i = 0; i < n; i++)
        {
            val++;
            num.Add(val);
        }
        for (int k = 0; k < n; k++)
        {
            div3 = num[k] % 3;
            div5 = num[k] % 5;
            if (div3 == 0 && div5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (div3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (div5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num[k]);
            }
        }
    }

}
class Solution
{
        //public static void Main(string[] args)
        //{
        //    //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    //FizzBuzz.fizzBuzz(n);
        //    Result.Kangaroo(0, 3, 4, 2);
        //    Console.ReadLine();
        //}
    }
}
