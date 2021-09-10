
//Equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes. 
using System;
using System.Collections.Generic;

namespace Assignment4_6
{
    class Program
    {
        static int equillibrium(int[] a, int n)
        {
            int sum_left = 0, sum = 0, eq, i = 0;
            bool found = false;

            /*eq = (int)n / 2;

            if (n == 1)
            {
                return 0;
            }
            for (int i = 0; i < eq; i++)
            {
                sum_left += a[i];
            }
            for (int i = eq + 1; i < n; i++)
            {
                sum_right += a[i];
            }
            while (eq < n - 1 && eq > 0)
            {
                if (sum_left < sum_right)
                {
                    sum_left += a[eq];
                    eq++;
                    sum_right -= a[eq];
                }
                if (sum_right < sum_left)
                {
                    sum_right += a[eq];
                    eq--;
                    sum_left -= a[eq];
                }
                if (sum_right == sum_left)
                {
                    found = true;
                    break;
                }
            }

            if (found == true)
                return eq;

            return -1;*/

           
            for (i = 0; i < n; i++)
            {
                sum += a[i];
                
            }

            for (i=0;i<n;i++)
             {
                Console.WriteLine(sum);
                sum =sum-a[i];
               

                 if(sum==sum_left)
                     {
                         found=true;
                         break;
                     }
                 sum_left += a[i];
                Console.WriteLine(sum_left);
            }
            if (found == true)
            {
                return i;
            }
            return -1;

        }
        static public void Main()
        {
            string val = Console.ReadLine(); ;
            int no_of_inputs = Convert.ToInt32(val);

            List<int> a = new List<int>();
           
            for (int k = 0; k < no_of_inputs; k++)
            {
                val = Console.ReadLine();
                int n = Convert.ToInt32(val);
                string[] num = Console.ReadLine().Split();
                int[] array = new int[10000];

                for (int j = 0; j < n; j++)
                {
                    array[j] = Convert.ToInt32(num[j]);
                   
                }

                int pt = equillibrium(array, n);
                Console.WriteLine(pt);
            }
        }
    }
}
