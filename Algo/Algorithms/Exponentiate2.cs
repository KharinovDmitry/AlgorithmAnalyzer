using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate2 : IAlgorithm<Tuple<int, int>> // num, pow
    {
        public void Execute(Tuple<int, int> input)
        {
            int result = Exponentiate(input.Item1, input.Item2); 
            
        }
        public static int Exponentiate(int value, int pow)
        {
            if (pow == 0)
                return value;
            if (pow > 0)
            {
                return (Exponentiate(value, pow - 1) * value);
            }
            return Exponentiate(value, -pow);
        }
       
    }
}
