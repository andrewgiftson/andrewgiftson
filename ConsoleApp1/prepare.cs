using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class prepare
    {
        public static void Main(string[] args)
        {
            List<int> ar = new List<int>();
            ar.Add(1); ar.Add(1); ar.Add(3); ar.Add(1); ar.Add(2); ar.Add(1); ar.Add(3); ar.Add(3); ar.Add(3);ar.Add(3);
            int n = 10;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (ar[i] == ar[j]) // comparing list value 0 == 1 0 == 2 
                        {
                            n -= 2; // changing the n value
                            count++; // adding count
                            //Console.WriteLine("i=" + ar[i] + "," + i);
                            ar.Remove(ar[i]); //removing first value

                            if (i > j || i==j) //if 
                            {
                               // Console.WriteLine("j+1=" + ar[j+1]+","+(j+1));
                                ar.Remove(ar[j+1]); //removing second value
                            }
                            else if(i<j )
                            {
                                //Console.WriteLine("j-1=" + ar[j-1] + "," + (j-1));
                                ar.Remove(ar[j - 1]); //removing second value
                            }
                            
                        }
                    }
                }
            }
            for(int k=0;k<n;k++)
            {
                Console.WriteLine(ar[k]); //ptinting remaining
            }
            Console.WriteLine("Repeat = "+count);
             Console.ReadLine();
        }
    }
}
