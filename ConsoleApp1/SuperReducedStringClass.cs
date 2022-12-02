using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperReducedStringClass
    {
        public static string SuperReducedString()
        {
            Console.WriteLine("Hello start from here");
            string s = "aabbcdd";
           
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j)
                    {
                        if (s[i] == s[j])
                        {
                            string SM = s.Remove(i);
                            break;
                        }
                    }
                }                              
            }
            if (s.Equals(null))
            {
                s = "Empty String";
            }
            Console.WriteLine("Hello start from here");
            return s;
            
        }
        public static void Main(string[] args)
        {
            SuperReducedString();
        }

    }
}

