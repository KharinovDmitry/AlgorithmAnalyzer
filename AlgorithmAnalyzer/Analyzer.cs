using Algo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalyzer
{
    internal class Analyzer
    {
        private const int lowerBoundN = 1;
        private const int higherBoundN = 2000;
        private const int countRepeat = 5;

        private static int step = ((higherBoundN - lowerBoundN) / 10) + 1;

        public static AnalyzeResult Evaluate(IAlgorithm<int[]> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = lowerBoundN; n < higherBoundN; n++)
            {
                if(n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {

                    int[] arr = GenerateRandomArray(n);
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(arr);
                    sw.Stop();
                    t_sum += sw.Elapsed.TotalSeconds;
                }
                double med_time = t_sum / 5;
                report.AddMeasurement(n, med_time);
            }

            Console.Clear();
            return report;
        }

        public static AnalyzeResult Evaluate(IAlgorithm<Tuple<int, int>> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = lowerBoundN; n < higherBoundN; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    int x = new Random().Next((int)(DateTime.Now.Ticks % i));
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(Tuple.Create(x, n));
                    sw.Stop();
                    t_sum += sw.Elapsed.TotalSeconds;
                }
                double med_time = t_sum / 5;
                report.AddMeasurement(n, med_time);
            }
            return report;
        }

        public static AnalyzeResult Evaluate(IAlgorithm<Tuple<int[,], int[,]>> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = lowerBoundN; n < higherBoundN; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    int[,] A = GenerateRandomMatrix(n);
                    int[,] B = GenerateRandomMatrix(n);
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(Tuple.Create(A, B));
                    sw.Stop();
                    t_sum += sw.Elapsed.TotalSeconds;
                }
                double med_time = t_sum / 5;
                report.AddMeasurement(n, med_time);
            }
            return report;
        }
        private static int[,] GenerateRandomMatrix(int n)
        {
            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] line = GenerateRandomArray(n);
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = line[j];
                }
            }
            return res;
        }
        private static int[] GenerateRandomArray(int n)
        {
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = new Random((int)(DateTime.Now.Ticks % (i + 1))).Next(0, 1000);
            }
            return res;
        }
    }
}
