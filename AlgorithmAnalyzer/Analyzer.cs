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
        private const int countRepeat = 5;

        //private static int step = ((higherBoundN - lowerBoundN) / 10) + 1;

        public static AnalyzeResult Evaluate(IAlgorithm<int[], int[]> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            var step = (2000 - 1) / 10 + 1;
            for (int n = 1; n < 2000; n++)
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
                double med_time = t_sum / countRepeat;
                report.AddMeasurement(n, med_time);
            }

            Console.Clear();
            return report;
        }

        public static AnalyzeResult Evaluate(IAlgorithm<int, Tuple<int, int>> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            var step = (2000 - 1) / 10 + 1;
            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = 1; n < 2000; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                int countStep_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    int x = new Random().Next((int)(DateTime.Now.Ticks % (i + 1)));
                    countStep_sum += algorithm.Execute(Tuple.Create(x, n));
                }
                double med_time = countStep_sum / countRepeat;
                report.AddMeasurement(n, med_time);
            }
            return report;
        }

        public static AnalyzeResult Evaluate(IAlgorithm<int, int[]> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            var step = (2000 - 1) / 10 + 1;
            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = 1; n < 2000; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    var arr = GenerateRandomArray(n);
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(arr);
                    sw.Stop();
                    t_sum += sw.Elapsed.TotalSeconds;
                }
                double med_time = t_sum / countRepeat;
                report.AddMeasurement(n, med_time);
            }
            return report;
        }

        public static AnalyzeResult Evaluate(IAlgorithm<double, int[]> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            var step = (2000 - 1) / 10 + 1;
            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = 1; n < 2000; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    var arr = GenerateRandomArray(n);
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(arr);
                    sw.Stop();
                    t_sum += sw.Elapsed.TotalSeconds;
                }
                double med_time = t_sum / countRepeat;
                report.AddMeasurement(n, med_time);
            }
            return report;
        }

        public static AnalyzeResult Evaluate(IAlgorithm<int[,], Tuple<int[,], int[,]>> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            var step = (200 - 1) / 10 + 1;
            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = 1; n < 100; n++)
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
        public static AnalyzeResult Evaluate(IAlgorithm<int[], int[,]> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            var step = (12 - 3) / 10 + 1;
            for (int n = 3; n < 12; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    int[,] graph = GenerateRandomConnectedGraph(n);
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(graph);
                    sw.Stop();
                    t_sum += sw.Elapsed.TotalSeconds;
                }
                double med_time = t_sum / countRepeat;
                report.AddMeasurement(n, med_time);
            }
            return report;
        }


        public static AnalyzeResult Evaluate(IAlgorithm<double[,], int> algorithm)
        {
            Console.WriteLine(algorithm.GetType().Name);
            Console.WriteLine("[..........]");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            var step = 1;
            AnalyzeResult report = new AnalyzeResult(algorithm.GetType().Name);
            for (int n = 1; n < 10; n++)
            {
                if (n % step == 0)
                {
                    Console.SetCursorPosition(n / step, Console.CursorTop);
                    Console.Write("-");
                }

                double t_sum = 0;
                for (int i = 0; i < countRepeat; i++)
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    algorithm.Execute(n);
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
        private static int[,] GenerateRandomConnectedGraph(int n)
        {
            Random rand = new Random();
            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int distance = rand.Next(10, 100);
                    res[i, j] = distance;
                    res[j, i] = distance;
                }
            }
            return res;
        }
    }
}
