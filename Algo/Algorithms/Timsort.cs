using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Timsort : IAlgorithm<int[], int[]>
    {
        public int[] Execute(int[] input)
        {
            int minRun = calcMinRun(input.Length);

            for (int start = 0; start < input.Length; start += minRun)
            {
                int end = Math.Min(start + minRun - 1, input.Length - 1);
                insertionSort(input, start, end);
            }
            int size = minRun;
            while (size < input.Length)
            {
                for (int left = 0; left < input.Length; left += 2 * size)
                {
                    int middle = Math.Min(input.Length - 1, left + size - 1);
                    int right = Math.Min(left + 2 * size - 1, input.Length - 1);
                    if (middle < right)
                    {
                        merge(input, left, middle, right);
                    }
                }

                size *= 2;
            }
            return input;
        }
        private int calcMinRun(int length)
        {
            int r = 0;
            while (length >= 32)
            {
                r |= length & 1;
                length >>= 1;
            }
            return length + r;
        }

        private void insertionSort(int[] arr, int left, int right)
        {
            int temp;
            for (int i = left + 1; i < right + 1; i++)
            {
                int j = i;
                while (j > left && arr[j] < arr[j - 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }

        private void merge(int[] arr, int left, int middle, int right)
        {
            int len1 = middle - left + 1, len2 = right - middle, i;
            int[] leftArr = new int[len1];
            int[] rightArr = new int[len2];
            for (i = 0; i < len1; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (i = 0; i < len2; i++)
            {
                rightArr[i] = arr[middle + 1 + i];
            }

            int j = 0, k = left;
            i = 0;
            while (i < len1 && j < len2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }

                k++;
            }
            while (i < len1)
            {
                arr[k] = leftArr[i];
                k++;
                i++;
            }
            while (j < len2)
            {
                arr[k] = rightArr[j];
                k++;
                j++;
            }
        }
    }
}
