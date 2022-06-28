using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RecursiveDigitSum
    {
        public static void Main(string[] args)
        {
            string n = "861568688536788999";
            ulong k = 100000;
            ulong nmod = 0, nadd = 0, nr = 0;
            ulong nom = ulong.Parse(n);
            //adding k numbers
            for (int superDigit = 0; superDigit < n.Count(); superDigit++)
            {
                nmod = nom % 10;
                nadd += nmod;
                nom /= 10;
            }
            UInt64 nmk = nadd * k;
            //Console.WriteLine(nmk);
            //super_Digit
            while (nmk.ToString().Count() > 1)
            {
                if (nmk / 10 == 0)
                {
                    Console.WriteLine(nmk); Console.ReadLine(); break;
                }
                else
                {
                    while (nmk > 0)
                    {
                        nr = nr + (nmk % 10);
                        nmk /= 10;

                    }
                    nmk = nr;
                    nr = 0;
                    //Console.WriteLine(nmk);
                }
            }
            Console.WriteLine(nmk);
            Console.ReadLine();
        }
    }
}
