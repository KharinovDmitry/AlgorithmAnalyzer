using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class ConstFunc : IAlgorithm<int, int[]>
    {
        public int Min => 1;

        public int Max => 500000;

        public int Step => 50;

        public int Execute(int[] input)
        {
            return input[0];
        }
    }
}
