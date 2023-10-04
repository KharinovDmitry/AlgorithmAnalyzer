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
            List<AnalyzeResult> results = new List<AnalyzeResult>
            {
                Analyzer.Evaluate(new BubbleSort()),
                Analyzer.Evaluate(new BubbleSort()),
                Analyzer.Evaluate(new ConstFunc()),
                Analyzer.Evaluate(new Exponentiate1()),
                Analyzer.Evaluate(new Exponentiate2()),
                Analyzer.Evaluate(new Exponentiate3()),
                Analyzer.Evaluate(new Exponentiate4()),
                Analyzer.Evaluate(new GenerateMap()),
                Analyzer.Evaluate(new GornerMethod()),
                Analyzer.Evaluate(new MultiplicationOfElements()),
                Analyzer.Evaluate(new MultiplyMatrix()),
                Analyzer.Evaluate(new Polynomial()),
                Analyzer.Evaluate(new QuickSort()),
                Analyzer.Evaluate(new SumOfElements()),
                Analyzer.Evaluate(new Timsort()),
                Analyzer.Evaluate(new TravellingSalesman())
            };
            results.ForEach(x => CsvWriter.WriteAnalyzeResult(x));
        } 
    }
}