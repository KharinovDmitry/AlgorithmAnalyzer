using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class SumOfElements : IAlgorithm<int, int[]>
    {
        public int Execute(int[] input)
        {
            var sum = 0;

            foreach (int number in input)
            {
                sum += number;
            }

            return sum;
        }
    }
}
