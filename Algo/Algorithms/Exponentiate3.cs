using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate3 : IAlgorithm<Tuple<int, int>>
    {
        public void Execute(Tuple<int, int> input)
        {
            int c = input.Item1; //value
            int k = input.Item2; //pow
            int result;

            if (k % 2 == 1)
                result = c;

            else
                result = 1;
            
            while (k > 0)
            {
                k /= 2;
                c *= c;
                if (k % 2 == 1)
                {
                    result *= c;
                }

            }
        }
    }
}
