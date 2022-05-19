using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpiralPrint spiralPrint = new SpiralPrint();
            //ReverseNumber reverseNumber = new ReverseNumber();
            //programmingknow1 programmingknow1 = new programmingknow1();
            // programmingknow1.fishorcrab();

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus.plusMinus(arr);

        }
    }
   
}
