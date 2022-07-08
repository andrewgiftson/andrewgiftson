using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountingValley
    {
        public static void counting(string[] args)
        {
            string path = "UDDDUDUU";   // UDDDUDUU DDUUDDUDUUUD
            /*	_          /\_
                 \  /\    /
                  \/  \/\/          */
            int u = 0;
            int d = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i].Equals('U'))
                {
                    u++;
                }
                else //D - part
                {
                    if (u == 0)
                    {
                        d++;
                    }
                    u--;
                }
            }
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
