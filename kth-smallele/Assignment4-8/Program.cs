
//Given an array and a number k where k is smaller than size of array, 
//we need to find the k’th smallest element in the given array.It is given that ll array elements are distinct

using System;

namespace Assignment4_8
{
    class Program
    {

        public static int Partition(int[] a, int start_index, int end_index)
        {
            int temp, low = start_index, high = end_index, pivotloc = low, pivot = a[high];
            
           
            for (int i = low; i < high; i++)
            {
                if (a[i] < pivot)
                {
                   
                    temp = a[i];                
                    a[i] = a[pivotloc];
                    a[pivotloc] = temp;
                    pivotloc++;

                }
            }
            temp = a[pivotloc];
            a[pivotloc] = a[high];
            a[high] = temp;
          
           for (int i=0;i<=end_index;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("done");
            Console.WriteLine(pivotloc);

            return pivotloc;
        }

        public static int findelement(int[] arr, int low, int high, int k)
        {
            int partition_index = -1;
            while (k != partition_index) {

                 partition_index = Partition(arr, low, high);

                if (k < partition_index)
                {
                    
                    high = partition_index - 1;
                    

                }

                else if (k > partition_index)
                {
                    
                    low=partition_index + 1;
                   


                }
                if (k == partition_index)
                {
                  
                    break;
                }
            }

            return arr[k];
        }

        static void Main(string[] args)

        {
            
           
                string val = Console.ReadLine();
                int n = Convert.ToInt32(val);
                string[] num = Console.ReadLine().Split();
                int[] array = new int[n];
                int[] result = new int[n];

                for (int j = 0; j < n; j++)
                {
                    array[j] = Convert.ToInt32(num[j]);

                }

                val = Console.ReadLine(); ;
                int k = Convert.ToInt32(val);

                int ele = findelement(array, 0, n - 1, k-1);
                Console.WriteLine("element");
                Console.WriteLine(ele);


          

        }

    }
}
