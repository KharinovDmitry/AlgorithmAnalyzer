using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate2 : IAlgorithm<int, Tuple<int, int>>
    {
        public int Min => 1;

        public int Max => 10000;

        public int Step => 5;

        public int Execute(Tuple<int, int> input)
        {
            var res = Exponentiate(input.Item1, input.Item2);
            return res.Item2;
        }
        public static (int, int) Exponentiate(int value, int pow)
        {
            int stepsCount = 0;
            int result = 1;

            if (pow == 0)
                return (1, stepsCount);
            if (pow == 1)
                return (value, stepsCount);

            stepsCount += 2;
            var res = Exponentiate(value, --pow);
            return (result * res.Item1, res.Item2 + stepsCount);
        }
       
    }
}
