using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate2 : IAlgorithm<int, Tuple<int, int>>
    {
        public int Execute(Tuple<int, int> input)
        {
            return Exponentiate(input.Item1, input.Item2); 
            
        }
        public static int Exponentiate(int value, int pow)
        {
            int countstep = 0;
            if (pow == 0)
            {
                countstep += 2;
                return countstep;
            }
            if (pow > 0)
            {
                countstep += 5;
                return (Exponentiate(value, pow - 1) * value);
            }
            return Exponentiate(value, -pow);
        }
       
    }
}
