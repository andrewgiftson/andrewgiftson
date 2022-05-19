using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class plusMinus
    {
        /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static void pM(List<int> arr)
        {
            int p_No = 0;
            int n_No = 0;
            int z_no = 0;
            int total_No = arr.Count();

            foreach (int var in arr)
            {
                if (var == 0)
                {
                    z_no += 1;
                }
                else if (var < 0)
                {
                    n_No += 1;
                }
                else
                {
                    p_No += 1;
                }
            }
            double positive = (double)p_No / total_No;
            double negative = (double)n_No / total_No;
            double zero = (double)z_no / total_No;
            Console.WriteLine(string.Format("{0:N6}", positive));
            Console.WriteLine(string.Format("{0:N6}",negative));
            Console.WriteLine(string.Format("{0:N6}", zero));
            Console.ReadLine();

        }
    }
}
