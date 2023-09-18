using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace AlgorithmAnalyzer
{
    internal class CsvWriter
    {
        public static void WriteAnalyzeResult(AnalyzeResult result)
        {
            //string pathCsvFile = "D:\\Charts.csv";
            //List<TimeMeasurement> measurements = new List<TimeMeasurement>();
            for (int i = 0; i < result.Measurements.Count; i++)
            {
                //var csv = new StringBuilder();
                var ArrLength = result.Measurements[i].ArrayLength;
                var Time = result.Measurements[i].TimeInS;
                var newLine = string.Format("{Lenght},{Time}", ArrLength, Time);
                using (StreamWriter sw = File.CreateText("D:\\Charts.csv"))
                {
                    sw.WriteLine(newLine);
                }
                    //File.WriteAllText(pathCsvFile, csv.ToString());
            }                                      
        }
    }
}
