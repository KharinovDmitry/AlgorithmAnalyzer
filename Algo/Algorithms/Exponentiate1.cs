using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate1 : IAlgorithm<Tuple<int, int>>

    {
        public void Execute(Tuple<int, int> input)
        {
            int k = 0;
            int result = 1;
            
            
            while (k < input.Item2)
            {
                result *= input.Item1;
                k++;
            }

        }
    }
}
