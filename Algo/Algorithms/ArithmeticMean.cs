using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class ArithmeticMean : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            int sum = 0;
            int count = 0;

            foreach (int n in input)
            {
                sum += n;
                count++;
            }

            float res = sum / count;
        }
    }
}
