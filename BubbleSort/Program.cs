using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] numsToSort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool swapped = true;
            int temp;
            int n = numsToSort.Length - 1;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < n; i++)
                {
                    if (numsToSort[i] > numsToSort[i + 1])
                    {
                        temp = numsToSort[i];
                        numsToSort[i] = numsToSort[i + 1];
                        numsToSort[i + 1] = temp;
                        swapped = true;
                    }
                }
                n -= 1;
            }

            Console.WriteLine(string.Join(", ", numsToSort));
        }
    }
}
