using Algo;
using Algo.Algorithms;
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
                new QuickSort()
            };
            List<IAlgorithm<Tuple<int, int>>> algorithmsPower = new List<IAlgorithm<Tuple<int, int>>>
            {

            };
            List<IAlgorithm<Tuple<int[,], int[,]>>> algorithmsOfMatrix = new List<IAlgorithm<Tuple<int[,], int[,]>>>
            {
                new MultiplyMatrix()
            };
            List<AnalyzeResult> results = new List<AnalyzeResult> ();
            results.AddRange(algorithmsOfIntArray.Select(x => Analyzer.Evaluate(x)).ToList());
            results.AddRange(algorithmsPower.Select(x => Analyzer.Evaluate(x)).ToList());
            results.AddRange(algorithmsOfMatrix.Select(x => Analyzer.Evaluate(x)).ToList());
            results.ForEach(x => CsvWriter.WriteAnalyzeResult(x));
        } 
    }
}