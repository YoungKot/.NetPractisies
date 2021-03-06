using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Users.Interfaces;

namespace Users
{
    public class CSVReader:IDataProvider
    {
        private readonly string _path;

        public CSVReader(string path)
        {
            _path = path;
        }
        
        public List<Result> GetResults() => GetTotal(_path).Item2;
        public List<User> GetUsers() => GetTotal(_path).Item1;
        public void SetData(List<Result> records) => WriteToCSVFile(_path, records);

        //TODO: Coding style: Use var to make code shorter
        List<User> users = new List<User>();
        List<Result> results = new List<Result>();
        /// <summary>
        /// Reads the data from csv file
        /// </summary>
        /// <param name="path">path to a file</param>
        /// <returns>Returns the data as list of users or results</returns>
        //TODO: Tuple with public method doesn't make code clear. It's better to create a class container for public methods
        //TODO: Value tuple is available.
        private (List<User>, List<Result>) GetTotal(string path)
        // public Tuple<List<User>, List<Result>> GetTotal(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (var reader = new StreamReader(path))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Context.RegisterClassMap<UserMap>();
                        csv.Context.RegisterClassMap<ResultMap>();
                        var isHeader = true;
                        while (csv.Read())
                        {
                            if (isHeader)
                            {
                                csv.ReadHeader();
                                isHeader = false;
                                continue;
                            }

                            
                            if (string.IsNullOrEmpty(csv.GetField(0)))
                            {
                                isHeader = true;
                                continue;
                            }

                            switch (csv.HeaderRecord[0])
                            {
                                case "UserId":
                                    users.Add(csv.GetRecord<User>());
                                    break;
                                case "Id":
                                    results.Add(csv.GetRecord<Result>());
                                    break;
                                default:
                                    throw new InvalidOperationException("Unknown record type.");
                            }
                        }
                    }
                    // return Tuple.Create(users, results);
                    return (users, results);
                }
                else
                {
                    throw new FileNotFoundException($"Could not find the file: {path}");
                }
            }
            //TODO: High: Purpose of this catch statement?
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            
        }
        
        private void WriteToCSVFile(string path, List<Result> records)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
