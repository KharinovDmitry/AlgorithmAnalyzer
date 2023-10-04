using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    internal class BucketSort : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            BucketSorting(input);
        }
        public void BucketSorting(int[] a) {
            List<int>[] aux = new List<int>[a.Length];

            for (int i = 0; i < aux.Length; i++) {
                aux[i] = new List<int>();
            }

            int minValue = a[0];
            int maxValue = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minValue)               
                    minValue = a[i];                 
                else if (a[i] > maxValue)
                    maxValue = a[i];
            }

            double numRange = maxValue - minValue;

            for (int i = 0; i < aux.Length; i++)
            {
                int bcktIdx = (int)Math.Floor((a[i] - minValue) / numRange * (aux.Length - 1));
                aux[bcktIdx].Add(a[i]);   
            }

            for (int i = 0; i < aux.Length; i++)
            {
                aux[i].Sort();
            }

            int idx = 0;

            for (int i = 0; i < aux.Length; i++)
            {
                for (int j = 0; j < aux[i].Count; j++)
                    a[idx++] = aux[i][j]; 
            }
        }

    }
}
