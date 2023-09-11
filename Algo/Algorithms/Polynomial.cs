using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Polynomial : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            double res = 0;
            double x = 1.5;

            for (int i = 1; i < input.Length; i++)
            {
                res += input[i - 1] * Math.Pow(x, i - 1);
            }
        }
    }
}
