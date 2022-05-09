using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SpiralPrint
    {
        public void Spiral(int num)
        {
            int size = num, row = 0, col = 0;
            int boundary = size - 1;
            int sizeleft = size - 1;
            int flag = 1;

            char move = 'r'; //move right

            int[,] matrix = new int[size, size];
            for (int i = 1; i <= size * size; i++)
            {
                matrix[row, col] = i; //creating two dimensional array (0,0)
                switch (move)
                {
                    case 'r': col += 1; break;  //go right
                    case 'd': row += 1; break;  //go down
                    case 'l': col -= 1; break;  //go left
                    case 'u': row -= 1; break;  //go up
                }
                if (i == boundary)
                {
                    boundary += sizeleft; //boundary = 4 + 4 = 8
                    if (flag == 1)
                    {
                        flag = 2;
                    }
                    else
                    {
                        flag = 1;
                        sizeleft -= 1;
                    }
                    switch (move)
                    {
                        case 'r': move = 'd'; break;
                        case 'd': move = 'l'; break;
                        case 'l': move = 'u'; break;
                        case 'u': move = 'r'; break;
                    }
                }
            }
            for (row = 0; row < size; row++)
            {
                for (col = 0; col < size; col++)
                {
                    if (matrix[row, col] < 10)
                    {
                        Console.Write(matrix[row, col] + "  ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
