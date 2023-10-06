using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class BucketSort : IAlgorithm<int[], int[]>
    {
        public int Min => 2;

        public int Max => 200000;

        public int Step => 50;

        public int[] Execute(int[] input)
        {
            BucketSorting(input);
            return input;
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
                if(numRange == 0)
                {
                    return;
                }
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
