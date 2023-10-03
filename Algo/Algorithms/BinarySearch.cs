using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class BinarySearch : IAlgorithm<int, int[]>
    {
        public int Execute(int[] input)
        {
            int searchableEl = new Random().Next(1, 1000);
            return binarySearch(input, searchableEl, 0, input.Length - 1);
        }

        private int binarySearch(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }

            var middle = (first + last) / 2;
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    return binarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    return binarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
    }
}
