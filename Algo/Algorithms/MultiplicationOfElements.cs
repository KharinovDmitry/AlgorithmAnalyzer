using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class MultiplicationOfElements : IAlgorithm<int, int[]>
    {
        public int Min => 1;

        public int Max => 100000;

        public int Step => 10;

        public int Execute(int[] input)
        {
            var res = 1;

            foreach (int number in input)
            {
                res *= number;
            }

            return res;
        }
    }
}
