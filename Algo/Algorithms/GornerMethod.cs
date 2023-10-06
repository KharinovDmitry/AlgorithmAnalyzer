using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class GornerMethod : IAlgorithm<double, int[]>
    {
        public int Min => 1;

        public int Max => 10000;

        public int Step => 1;

        public double Execute(int[] input)
        {
            return CalcP(input, 0, 1.5);
        }

        private double CalcP(int[] input, int n, double x)
        {
            if (n == input.Length - 1)
            {
                return input[n];
            }

            return input[n] + x * CalcP(input, n + 1, x);
        }
    }
}
