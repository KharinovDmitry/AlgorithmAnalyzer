using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class ConstFunc : IAlgorithm<int, int[]>
    {
        public int Execute(int[] input)
        {
            return input[0];
        }
    }
}
