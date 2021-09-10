//Write a program to sort an array of 0's,1's and 2's in ascending order.
using System;

namespace Assignment4_5
{
    class Program
    {


        static void sort(int[] a, int n)
        {
            int low = 0, mid = 0, high = n - 1, temp = 0;

            while (mid <= high)
            {
                if (a[mid] == 0)
                {
                    temp = a[low];
                    a[low] = a[mid];
                    a[mid] = temp;
                    mid++;
                    low++;
                }
                else if (a[mid] == 1)
                {
                    mid++;

                }
                else if (a[mid] == 2)
                {
                    temp = a[high];
                    a[high] = a[mid];
                    a[mid] = temp;
                    high--;
                }
            }
        }
        static void Main(string[] args)
        {
			string val = Console.ReadLine();
			int no_of_inputs = Convert.ToInt32(val);

			for (int k = 0; k < no_of_inputs; k++)
			{
				val = Console.ReadLine(); ;
				int n = Convert.ToInt32(val);
				string[] num = Console.ReadLine().Split();
				int[] array = new int[10000];
			
				for (int j = 0; j < n; j++)
				{
					array[j] = Convert.ToInt32(num[j]);

				}
				sort(array, n);
				for (int j = 0; j < n; j++)
				{
					Console.Write(array[j]);
					Console.Write(" ");
				}
				Console.WriteLine();

			}
		}
    }
}
