
//Print the elements of an array in the decreasing frequency if 2 numbers have same frequency then print the one which came first

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Assinment4_10
{
    class Program
    {


      
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            Dictionary<int, int> indexes = new Dictionary<int, int>();
           
            int i = 0, k = 0, n = 0, j = 0,len=0;
            int[] array = new int[10000];
            string val = Console.ReadLine();
            n = Convert.ToInt32(val);
            string[] num = Console.ReadLine().Split();
            int freq = 1;


            for (j = 0; j < n; j++)  //O(n)
            {
                array[j] = Convert.ToInt32(num[j]);

                if (!numbers.TryGetValue(array[j],out freq))  //creating keys for elements in window
                {
                    numbers.Add(array[j], 1);
                    indexes.Add(array[j], j);
                }

                else
                {
                    numbers[array[j]]++;
                }
            }

            var ordered = numbers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); //O(nlogn))
            

            


            int m = 0;
           while(ordered.Count>0) // 0(length of dictionary)*0(length of index dictionary)
            {
                m = 0;
                int small_element_index = ordered.ElementAt(m).Key;
                len = ordered.Count;
                if (len >= 2)
                {
                   while (ordered.ElementAt(m).Value == ordered.ElementAt(m + 1).Value)
                   {

                        if(indexes[ordered.ElementAt(m + 1).Key]< indexes[small_element_index])
                                {
                                    small_element_index = ordered.ElementAt(m + 1).Key;
                                }
                        m++;
                        len--;
                        if (len == 1) {
                            break;
                        }

                    }
                }

                for(int occ=0;occ<ordered[small_element_index];occ++)
                {
                    Console.Write(small_element_index);
                    Console.Write(" ");
                }
               

                ordered.Remove(small_element_index);




            }



        }
    }
}
