using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Algorithms
{
    public class GenerateMap : IAlgorithm<double[,], int>
    {
        public double[,] Execute(int n)
        {
            MapGenerator mapGen = new MapGenerator(n);
            return mapGen.Map;
        }
    }
    public class MapGenerator
    {
        public double[,] Map { get; }
        public int Size { get; }
        public int Rang { get; }

        public MapGenerator(int rang)
        {
            Rang = rang;
            Size = (int)Math.Pow(2, rang);
            Map = GenerateMap();
            Smooth(Map, 10);
        }

        private double[,] GenerateMap()
        {
            Perlin[] perlins = GeneratePelins();
            double[,] res = new double[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    double sum = 0;
                    foreach (var el in perlins)
                    {
                        sum += el.Matrix[i, j];
                    }
                    res[i, j] = Math.Round(sum / Rang, 2);
                }
            }
            return res;
        }

        private void Smooth(double[,] res, int k)
        {
            for (int k0 = 0; k0 < k; k0++)
            {
                for (int i = 1; i < Size - 1; i++)
                {
                    for (int j = 1; j < Size - 1; j++)
                    {
                        res[i, j] = MiddleOf(i, j);
                    }
                }
            }
        }

        private double MiddleOf(int x, int y)
        {
            double res = 0;
            int c = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if ((x + i < Size) && (y + j < Size) && (x + i > 0) && (y + j > 0))
                    {
                        res += Map[x + i, y + j];
                        c++;
                    }
                }
            }
            return res / c;
        }

        private Perlin[] GeneratePelins()
        {
            Perlin[] res = new Perlin[Rang];
            for (int i = 0; i < Rang; i++)
            {
                res[i] = new Perlin((int)Math.Pow(2, i + 1));
                res[i].UpRang(Size);
            }
            return res;
        }

        private class Perlin
        {
            public int Rang { get; set; }
            public int[,] Matrix { get; set; }

            public Perlin(int rang)
            {
                Rang = rang;
                Matrix = GenerateMatrix(rang);
            }

            private int[,] GenerateMatrix(int rang)
            {
                int[,] res = new int[rang, rang];
                Random r = new Random();
                for (int i = 0; i < rang; i++)
                {
                    for (int j = 0; j < rang; j++)
                    {
                        res[i, j] = r.Next(0, 2);
                    }
                }
                return res;
            }

            public void UpRang(int newRang)
            {
                if (newRang < Rang || newRang % Rang != 0) 
                    throw new ArgumentException();

                int[,] newMatrix = new int[newRang, newRang];
                int k = newRang / Rang;
                for (int i = 0; i < newRang; i++)
                {
                    for (int j = 0; j < newRang; j++)
                    {
                        newMatrix[i, j] = Matrix[i / k, j / k];
                    }
                }
                Rang = newRang;
                Matrix = newMatrix;
            }
        }
    }
}
