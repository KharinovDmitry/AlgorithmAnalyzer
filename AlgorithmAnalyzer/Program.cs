using Algo;
using Algo.Algorithms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAlgorithm<int[]>> algorithmsOfIntArray = new List<IAlgorithm<int[]>>
            {
                new BinarySearch(),
                new ConstFunc(),
                new BubbleSort(),
                new Timsort(),
                new SumOfElements(),
                new MultiplicationOfElements(),
                new Polynomial(),
                new QuickSort(),
                new GornerMethod()

            };
            List<IAlgorithm<Tuple<int, int>>> algorithmsPower = new List<IAlgorithm<Tuple<int, int>>>
            {

            };
            List<IAlgorithm<Tuple<int[,], int[,]>>> algorithmsOfMatrix = new List<IAlgorithm<Tuple<int[,], int[,]>>>
            {
                new MultiplyMatrix()
            };
            List<IAlgorithm<int[,]>> algorithmsOfConnectedGraphs = new List<IAlgorithm<int[,]>>
            {
                new TravellingSalesman()
            };
            List<AnalyzeResult> results = new List<AnalyzeResult>();
            results.AddRange(algorithmsOfIntArray.Select(x => Analyzer.Evaluate(x)).ToList());
            results.AddRange(algorithmsPower.Select(x => Analyzer.Evaluate(x)).ToList());
            results.AddRange(algorithmsOfMatrix.Select(x => Analyzer.Evaluate(x)).ToList());
            results.AddRange(algorithmsOfConnectedGraphs.Select(x => Analyzer.Evaluate(x)).ToList());
            results.ForEach(x => CsvWriter.WriteAnalyzeResult(x));
        } 
    }
}