﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class BubbleSort : IAlgorithm<int[], int[]>
    {
        public int Min => 2;

        public int Max => 20000;

        public int Step => 50;

        public int[] Execute(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int t = input[j];
                        input[j] = input[j + 1];
                        input[j + 1 ] = t;
                    }
                }
            }
            
            return input;
        }
    }
}
