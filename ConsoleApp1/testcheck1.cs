using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace ConsoleApp1
{
    class testcheck1
    {
        public static void testcheck()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }



            //my program
            int rowCount = arr[0].Count;
            int diagonal1 = 0;
            int diagonal2 = 0;
            int k = 0;
            int diff = 0;
            for (int i = 0; i < rowCount; i++)
            {
                diagonal1 += arr[i][i];
            }
            for (int j = rowCount - 1; j >= 0; j--)
            {
                diagonal2 += arr[j][k];
                k++;
            }
            if (diagonal1 > diagonal2)
            {
                diff = diagonal1 - diagonal2;
            }
            else
            {
                diff = diagonal2 - diagonal1;
            }
            Console.WriteLine( diff);
            Console.ReadLine();
        }
        
    }  
    
}
