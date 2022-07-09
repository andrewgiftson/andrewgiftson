using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NewYearChaos
    {
        public static void NewyearChaos(string[] args)
        {
            //input
            List<int> q = new List<int>();
            q.Add(1); q.Add(4); q.Add(2); q.Add(3); q.Add(5);
            int count = 0;
            //process
            for (int i = 0; i < q.Count; i++)
            {
                if (i != 0)
                {
                    if (q[i] < q[i + 1] && q[i] > q[i - 1])
                    {
                        
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            if(count>3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");    
            }
        }

    }
}

