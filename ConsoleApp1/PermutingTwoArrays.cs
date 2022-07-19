using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    public class PermutingTwoArrays
    {
        public static void twoarrays(string[] args)
        {
            int k = 10;
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            A.Add(2);
            A.Add(1);
            A.Add(3);
            B.Add(7);
            B.Add(8);
            B.Add(7);
            string result = twoArrays(k,A,B);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            int i;   
            if (A.Count == B.Count)
            {
                for (i = 0; i < A.Count; i++)
                {
                  if((A[i] + B[i])<k)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }                                    
                }
            }
            return null;
            
        }
    }
}
