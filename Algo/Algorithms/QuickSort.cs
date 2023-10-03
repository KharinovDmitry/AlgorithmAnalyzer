using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class QuickSort : IAlgorithm<int[], int[]>
    {
        public int[] Execute(int[] input)
        {
            Sort(input, 0, input.Length - 1);
            return input;
        }

        private void Sort(int[] input, int startIndex, int endIndex)
        {
            if (endIndex <= startIndex)
            {
                return;
            }

            int pivotIndex = Partition(input, startIndex, endIndex);
            Sort(input, startIndex, pivotIndex - 1);
            Sort(input, pivotIndex + 1, endIndex);
        }

        private int Partition(int[] input, int startIndex, int endIndex)
        {
            int pivot = input[endIndex];
            int i = startIndex - 1;

            for (int j = startIndex; j <= endIndex - 1; j++)
            {
                if (input[j] < pivot)
                {
                    i++;
                    Swap(input, i, j);
                }
            }

            i++;
            Swap(input, i, endIndex);

            return i;
        }

        private void Swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
