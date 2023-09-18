using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class DoubleNull : IAlgorithm<int[]>
    {
        public void Execute(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    for (int j = x.Length - 2; j >= i; j--)
                    {
                        x[j + 1] = x[j];

                    }
                    i++;

                }

            }
        }
    }
}
