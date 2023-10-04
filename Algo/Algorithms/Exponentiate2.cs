using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate2 : IAlgorithm<int, Tuple<int, int>>
    {
        private static int countstep = 0;
        public int Execute(Tuple<int, int> input)
        {
            var res = Exponentiate(input.Item1, input.Item2);
            return res.Item2;
        }
        public static (int, int) Exponentiate(int value, int pow)
        {
            if (pow == 0)
            {
                countstep += 2;
                return (1, countstep);
            }
            if (pow > 0)
            {
                countstep += 5;
                var res = Exponentiate(value, pow - 1);
                return (res.Item1 * value, res.Item2);
                
            }
            return Exponentiate(value, -pow);
        }
       
    }
}
