﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class MultiplicationOfElements : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            var res = 1;

            foreach (int number in input)
            {
                res *= number;
            }
        }
    }
}