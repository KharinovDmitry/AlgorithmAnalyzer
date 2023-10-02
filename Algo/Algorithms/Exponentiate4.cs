using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate4 : IAlgorithm<Tuple<int, int>>
    {
        public void Execute(Tuple<int, int> input)
        {
            Exponentiate(input.Item1, input.Item2);
        }

        public static (int Result, int Count) Exponentiate(int value, int pow)
        {
            int countstep = 3;
            int c = value;
            int k = pow;
            int result = 1;

            while (k != 0)
            {
                countstep += 1;
                if (k % 2 == 0)
                {
                    c *= c;
                    k /= 2;
                    countstep += 3;
                }
                else
                {
                    result *= c;
                    k -= 1;
                    countstep += 3;
                }
            }
            countstep += 1;
            return (result, countstep);
        }
    }
}
