
//Given a 2D array, print it in spiral form.

using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;

namespace Assignment4_9
{
    class Program
    {
       
        static void spiral_print(int row,int col,int[,] a)
        {
            int first_row = 0, first_col = 0;
            int last_row = row - 1, last_col = col - 1;
            while(first_row<=last_row && first_col<=last_col)
            {
                for(int i=first_col;i<=last_col;i++)
                {
                    Console.Write(a[first_row,i]);
                    Console.Write(" ");
                }
                first_row++;
                for(int i=first_row;i<=last_row;i++ )
                {
                    Console.Write(a[i, last_col]);
                    Console.Write(" ");
                }
                last_col--;

                if(first_row<=last_row)
                {
                    for(int i =last_col;i>=first_col;i--)
                    {
                        Console.Write(a[last_row, i]);
                        Console.Write(" ");
                    }

                    last_row--;
                }
                if(first_col<=last_col)
                {
                    for(int i=last_row;i>=first_row;i--)
                    {
                        Console.Write(a[i, first_col]);
                        Console.Write(" ");
                    }

                    first_col++;
                   
                }


            }




            Console.WriteLine("done");
        }
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 2, 3, 6 }, {4, 5, 9 },{6, 7, 8}, { 26, 27, 28 } };

            int row_max = 4, col_max = 3;
            spiral_print(row_max, col_max, a);

        }
    }
}
