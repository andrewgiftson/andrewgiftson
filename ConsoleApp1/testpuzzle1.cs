using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class testpuzzle1
    {
        public static void puzzle1(string[] args)
        {
			int ascii = 97;
			int n = 5;
			for (int i = 0; i < n; i++)
			{
				for (int j = 1; j < n - i; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k<i+2; k++)
				{
					Console.Write(Convert.ToChar(ascii));
					ascii++;
				}
				Console.WriteLine();
				ascii = 97;
			}
		}
    }
}
