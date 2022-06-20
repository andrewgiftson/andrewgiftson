//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace ConsoleApp1
//{
    

//    class Result
//    {

//        /*
//         * Complete the 'countApplesAndOranges' function below.
//         *
//         * The function accepts following parameters:
//         *  1. INTEGER s
//         *  2. INTEGER t
//         *  3. INTEGER a
//         *  4. INTEGER b
//         *  5. INTEGER_ARRAY apples
//         *  6. INTEGER_ARRAY oranges
//         */

//        public static void countApplesAndOranges(int houseStart, int houseEnd, int appleTree, int orangeTree, List<int> apples, List<int> oranges)
//        {
//            int appleCount = 0, orangeCount = 0;
//            List<int> appleList = new List<int>();
//            List<int> orangeList = new List<int>();
//            for (int i = 0; i < apples.Count; i++)
//            {
//                int aAdd = 0;
//                aAdd = appleTree + apples[i];
//                appleList.Add(aAdd);
//                if (aAdd >= houseStart && aAdd <= houseEnd)
//                {
//                    appleCount++;
//                }
//            }
//            Console.WriteLine(appleCount);
//            for (int j = 0; j < oranges.Count; j++)
//            {
//                int oAdd = 0;
//                oAdd = orangeTree + oranges[j];
//                orangeList.Add(oAdd);
//                if (oAdd >= houseStart && oAdd <= houseEnd)
//                {
//                    orangeCount++;
//                }
//            }
//            Console.WriteLine(orangeCount);

//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int s = Convert.ToInt32(firstMultipleInput[0]);

//            int t = Convert.ToInt32(firstMultipleInput[1]);

//            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int a = Convert.ToInt32(secondMultipleInput[0]);

//            int b = Convert.ToInt32(secondMultipleInput[1]);

//            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int m = Convert.ToInt32(thirdMultipleInput[0]);

//            int n = Convert.ToInt32(thirdMultipleInput[1]);

//            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

//            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

//            Result.countApplesAndOranges(s, t, a, b, apples, oranges);
//        }
//    }
//}
