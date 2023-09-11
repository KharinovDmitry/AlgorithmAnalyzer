using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class MultiplyMatrix : IAlgorithm<Tuple<int[,], int[,]>>
    {
        public void Execute(Tuple<int[,], int[,]> input)
        {
            var A = input.Item1;
            var B = input.Item2;

            int n = (int)Math.Sqrt(A.Length);

            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        res[i, j] += A[i, c] * B[c, j];
                    }
                }
            }
        }
    }
}

