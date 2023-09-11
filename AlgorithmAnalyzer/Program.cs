using Algo;
using Algo.Algorithms;

namespace AlgorithmAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAlgorithm> algorythms = new List<IAlgorithm>()
            {
                new BubbleSort(),
                new ConstFunc()
            };
            foreach (var algo in algorythms)
            {
                Console.WriteLine(algo.GetType().Name);    
                var result = Analyzer.Evaluate(algo);
                Console.WriteLine(result.ToString());
                CsvWriter.WriteAnalyzeResult(result);
            }
        }
    }
}