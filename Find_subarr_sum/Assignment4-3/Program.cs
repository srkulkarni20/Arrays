
//Given an unsorted array of nonnegative integers, find a continous subarray which adds to a given number.

using System;

namespace Assignment4_3
{
    class Program
    {

		static public void find_subarray(int[] a, int n, int req_sum)
		{
			int start_index = 0, end_index = 0, sub_sum = 0, i = 0;
			bool found = false;

			sub_sum = 0;
			
			
			for(i=0;i<n; i++)
			{
				sub_sum += a[i];
				end_index = i;

				while (sub_sum > req_sum  && start_index < end_index)  
				{
					sub_sum = sub_sum - a[start_index];
					start_index++;
				}
				if(sub_sum==req_sum)
				{
					found = true;				
					break;
				}

			}
				
			
			if (found == true)
			{
				Console.Write(start_index );
				Console.Write(" ");
				Console.WriteLine(end_index );
			}
			else
			{
				Console.WriteLine("Not Found");
			}


		}

		static void Main(string[] args)
        {
			int  n, sum_f = 0;
		
			
				int[] array = new int[100000];
				string[] values = Console.ReadLine().Split();
				n = Convert.ToInt32(values[0]);
				sum_f = Convert.ToInt32(values[1]);

				string[] num = Console.ReadLine().Split();
				int j = 0;
				for (j = 0; j < n; j++)
				{
					array[j] = Convert.ToInt32(num[j]);

				}

				find_subarray(array, n, sum_f);

			
		}
    }
}
