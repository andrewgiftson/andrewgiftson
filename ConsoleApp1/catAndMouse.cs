using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class catAndMouse
    {
        public string catAndMou()
        {
            int x=1; //cat1
            int y=3; //cat2
            int z=2; //mouse - dont move until two cats meet a same point
            string result = string.Empty;
            if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                Console.WriteLine("Cat A");
                result = "Cat A";
            }
            else if (Math.Abs(z - x) > Math.Abs(z - y))
            {
                Console.WriteLine("Cat B");
                result = "Cat B";
            }
            else if (Math.Abs(z - x) == Math.Abs(z - y))
            {
                Console.WriteLine("Mouse C");
                result = "Mouse C";
            }
            return result;
        }
    }
}
