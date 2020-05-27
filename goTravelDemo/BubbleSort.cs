using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goTravelDemo
{
    public class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] items = new int []{ 6, 0, 3, 5, -5, 8, 3, 1 };
            var sorted = DoBubbleSort(items);
            Console.WriteLine(sorted);
        }
        public static int[] DoBubbleSort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
