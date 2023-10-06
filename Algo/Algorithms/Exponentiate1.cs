using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class Exponentiate1 : IAlgorithm<int, Tuple<int, int>>

    {
        public int Min => 1;

        public int Max => 200000;

        public int Step => 10;

        public int Execute(Tuple<int, int> input)
        {
            int k = 0;
            int countsteps = 3;
            int result = 1;
            
            
            while (k < input.Item2)
            {
                result *= input.Item1;
                countsteps += 2;
                k++;
            }

            return countsteps;
        }
    }

}
