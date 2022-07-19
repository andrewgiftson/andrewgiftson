using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Drawing
    {
        public static void drawingBook()
        {
            int n=6, p=2;
            int pageFront = 0, pageBack = 0, FPage = 0, BPage = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == p)
                {
                    FPage = pageFront;break;
                }
                else if (i != p)
                {
                    int div = i % 2;
                    if (i == 1)
                    {
                        pageFront++;
                    }
                    else if (div != 0)
                    {
                        pageFront++;
                    }
                }
            }
            for (int j = n; j >= 0; j--)
            {
                if (j == p)
                {
                    BPage = pageBack;break;
                }
                else if (j != p)
                {
                    int div = j % 2;
                    if (div == 0)
                    {
                        pageBack++;
                    }
                }
            }
            if (FPage < BPage)
            {
                Console.WriteLine(FPage);
            }
            else if (BPage < FPage)
            {
                Console.WriteLine(BPage);
            }
            else if (BPage == FPage)
            {
                Console.WriteLine(FPage);
            }
            else
            {
                Console.WriteLine("empty");
            }
        }

    }
}
