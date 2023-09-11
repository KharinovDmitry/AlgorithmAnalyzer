using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class BubbleSort : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        int t = input[i];
                        input[i] = input[j];
                        input[j] = t;
                    }
                }
            }
        }
    }
}
