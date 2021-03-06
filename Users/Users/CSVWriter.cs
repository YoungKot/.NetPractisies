using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class CSVWriter
    {   
        /// <summary>
        /// Writes provided data to a csv file
        /// </summary>
        /// <param name="path">path to the file</param>
        /// <param name="records">records to be written to a file</param>
        // public void WriteToCSVFile(string path, List<Result> records)
        // {
        //     using (var writer = new StreamWriter(path))
        //     using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        //     {
        //         csv.WriteRecords(records);
        //     }
        // }
    }
}
