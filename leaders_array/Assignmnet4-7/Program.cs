//Write a program to print all the LEADERS in the array.An element is leader if it is greater than all the elements to its right side.
    //And the rightmost element is always a leader.For example int the array { 16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2

using System;

namespace Assignmnet4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -34, 3, 7, 5, 6, 7 };
            int max_ele_so_far = a[a.Length - 1];
            int[] leaders = new int[a.Length];
            int k = 0;
            leaders[k++] = a[a.Length - 1];
            for (int i=a.Length-2;i>=0 ;i--)
            {
                if(a[i]>=max_ele_so_far)
                {
                    max_ele_so_far = a[i];
                    leaders[k++] = max_ele_so_far;
                }

            }

            for (int i = k-1;i>=0;i--)
            {
                Console.WriteLine(leaders[i]);
            }
        }
    }
}
