using Algo;
using Algo.Algorithms;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAlgorithm<int[]>> algorithmsOfInt = new List<IAlgorithm<int[]>>
            {
                new ConstFunc(),
                new BubbleSort()
            };
            List<AnalyzeResult> results = new List<AnalyzeResult> ();
            results.AddRange(algorithmsOfInt.Select(x => Analyzer.Evaluate(x)).ToList());
        } 
    }
}