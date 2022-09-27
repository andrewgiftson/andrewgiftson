using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dono
    {
        public static void Donos(string[] args)
        {
            List<int> ar = new List<int>();
            ar.Add(1); ar.Add(2); ar.Add(3); ar.Add(4); ar.Add(1); ar.Add(2); ar.Add(3); ar.Add(4); ar.Add(1); ar.Add(2);
            //implementation
            var dict = new Dictionary<int, int>();
            for(int i= 0; i <ar.Count() ; i++)
            {
                if (!dict.ContainsKey(ar[i]))
                {
                    dict.Add(ar[i], 1);
                }
                else
                {
                    dict[ar[i]]++;
                }
            }
            var max = dict.Values.Max();
            var stack = new Stack<int>();
            foreach(var item in dict)
            {
                if(max==item.Value)
                {
                    stack.Push(item.Key);
                }
            }
            var min = stack.Min();
            Console.WriteLine( "min= "+min);
        }
    }
} 
