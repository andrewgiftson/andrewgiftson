using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseNumber
    {
        public void reverseNumber(int num)
        {
            int[] number =new int[100];
            Console.WriteLine("Enter numbers");
            for(int i=0;i<num;i++)
            {
                number[i]=Convert.ToInt32(Console.ReadLine());
            }
            
            
            Console.WriteLine("Entered values:");
            for(int i=0;i<num;i++)
            {
                Console.Write(number[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Reverse values:");
            for(int i=num-1;i>=0;i--)
            {
                Console.Write(number[i]+ ", ");
            }


            //for viewing result
            Console.ReadLine();
        }
    }
}
