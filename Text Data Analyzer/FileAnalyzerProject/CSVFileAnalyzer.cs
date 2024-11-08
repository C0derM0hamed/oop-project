using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
    public class CSVFileAnalyzer : FileAnalyzer,IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] fileString = File.ReadAllLines(fileInfo.FullName);

          var rowElements = fileString[0].Split(',');

            AnalysisResults results = new AnalysisResults();
        
            results.filedCount = rowElements.Length;
            SetResults(results);
        }
    }
}
