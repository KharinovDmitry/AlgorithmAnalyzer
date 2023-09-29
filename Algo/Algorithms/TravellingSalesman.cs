using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class TravellingSalesman : IAlgorithm<int[,]>
    {
        int[,] distanceMatrix;
        int[] bestTour;
        int bestTourCost;
        int n;

        public void Execute(int[,] input)
        {
            distanceMatrix = input;
            n = distanceMatrix.GetLength(0);
            bestTour = new int[n];
            bestTourCost = int.MaxValue;
            for (int startCity = 0; startCity < n; startCity++)
            {
                FindBestTour(startCity, new int[] { startCity }, 0);
            }

            int[] temp = new int[bestTour.Length + 1];
            bestTour.CopyTo(temp, 0);
            temp[temp.Length - 1] = 0;
            bestTour = temp;
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

                    if (nextCity >= bestTourCost)
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
