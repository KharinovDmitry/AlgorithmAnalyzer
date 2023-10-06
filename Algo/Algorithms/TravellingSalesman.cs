using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class TravellingSalesman : IAlgorithm<int[], int[,]>
    {
        int[,] distanceMatrix;
        int[] bestTour;
        int bestTourCost;
        int n;

        public int Min => 3;

        public int Max => 17;

        public int Step => 1;

        public int[] Execute(int[,] input)
        {
            distanceMatrix = input;
            n = distanceMatrix.GetLength(0);
            bestTour = new int[n];
            bestTourCost = int.MaxValue;

            FindBestTour(0, new int[] { 0 }, 0);

            return bestTour;
        }

        private void FindBestTour(int currentCity, int[] visitedCities, int currentCost)
        {
            if (visitedCities.Length == n)
            {
                int tourCost = currentCost + distanceMatrix[currentCity, visitedCities[0]];
                
                if (tourCost < bestTourCost)
                {
                    bestTour = visitedCities;
                    bestTourCost = tourCost;
                }

                return;
            }

            for (int nextCity = 0; nextCity < n; nextCity++)
            {
                if (Array.IndexOf(visitedCities, nextCity) == -1)
                {
                    int newCost = currentCost + distanceMatrix[currentCity, nextCity];

                    if (newCost >= bestTourCost)
                    {
                        continue;
                    }

                    int[] newVisitedCities = new int[visitedCities.Length + 1];
                    visitedCities.CopyTo(newVisitedCities, 0);
                    newVisitedCities[newVisitedCities.Length - 1] = nextCity;
                    FindBestTour(nextCity, newVisitedCities, newCost);
                }
            }
        }
    }
}
