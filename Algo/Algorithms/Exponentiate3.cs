using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate3 : IAlgorithm<int, Tuple<int, int>>
    {
        public int Execute(Tuple<int, int> input)
        {
            int countstep = 3;
            int c = input.Item1; 
            int k = input.Item2; 
            int result;

            if (k % 2 == 1)
            {
                result = c;
                countstep += 2;
            }
            else
            {
                result = 1;
                countstep += 2;
            }
            while (k > 0)
            {
                k /= 2;
                c *= c;
                countstep += 3;
                if (k % 2 == 1)
                {
                    countstep += 2;
                    result *= c;
                }
            }
            countstep += 1;
            return countstep;
        }
    }
}
