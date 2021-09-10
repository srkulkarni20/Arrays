//You are given a list of n-1 integers and these integers are in the range of 1 to n.There are no duplicates in list.
//One of the integers is missing in the list. Write an efficient code to find the missing integer.
using System;

namespace Assignmnet4_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int no_of_inputs, n;
			string val = Console.ReadLine();
			no_of_inputs = Convert.ToInt32(val);

			for (int i = 0; i < no_of_inputs; i++)
			{
				int[] array = new int[100000];
				val = Console.ReadLine();
				n = Convert.ToInt32(val);

				string[] num = Console.ReadLine().Split();
				int j = 0, sum = 0;
				for (j = 0; j < n - 1; j++)
				{
					array[j] = Convert.ToInt32(num[j]);
					sum += array[j];
				}

				int mis_num = (n * (n + 1) / 2) - sum;
				Console.WriteLine(mis_num);


			}

		}
	}
}
    

