using FileAnalyzerProject;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcom to File analyzer");
            Console.WriteLine("Please enter folder path to analyze");

            string inputFolder= Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);
            if (directoryInfo.Exists == false) 
            {
                Console.WriteLine("Folder dosnt exist");
                return;
            }
            var filenames = directoryInfo.GetFiles();
            IFileAnalysis fileAnalysis = null;
            foreach (var file in filenames) 
            {
                if (file.IsTextFile())
                {
                    fileAnalysis = new TxtFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Word count : {results.WordCount}");
                    Console.WriteLine($"Charachter count: {results.CharachterCount}");
                    Console.WriteLine($"Line count : {results.LineCount}");
                }
                else if (file.IsCsvFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Filed count : {results.filedCount}");
                }


            }


            foreach (var file in filenames) 
            {
                if (file.IsTextFile()) { }
                else if (file.IsCsvFile()){ }
            }

        }
    }
}