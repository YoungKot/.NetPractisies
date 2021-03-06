using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Interfaces;

namespace Users
{
    public class Validator
    {
        //TODO: Readonly?
        CSVWriter Writer;
        //if the reference never change use readonly
        private readonly IDataProvider _dataProvider;
        PathConstructor Path;
        Result Result;
        
        //TODO: Medium: Looks like some DI logic is tightly coupled with implementation. Think about correct abstractions 
        public Validator(CSVWriter writer, IDataProvider dataProvider, PathConstructor path, Result result)
        {
            this.Writer = writer;
            _dataProvider = dataProvider;
            this.Path = path;
            this.Result = result;
        }

        /// <summary>
        /// Checks if the file with user count exists, if not creates it, else retrieves the data from the existing file
        /// </summary>
        /// <param name="directory">directory name</param>
        /// <param name="fileName">file name</param>
        /// <param name="total">total amount of users</param>
        /// <param name="lvs">total amount of users in LV</param>
        /// <param name="lts">total amount of users in LT</param>
        /// <param name="ests">total amount of users in EE</param>
        public void ValidateFile(string directory, string fileName, int total, int lvs, int lts, int ests)
        {
            // If parameter has this in front of it, the method can be used as extension
            //var listi = new List<User>();
            //listi.GetUsersByCountryCount("LV");
            //TODO: Looks like records is initialized with empty list, but the list is never used. Most probably it will be removed by compiler. 
            //List<Result> records = new List<Result>();
            string[] files = Directory.GetFiles(directory, "UserC*");
            if (files.Length == 1)
            {
                //TODO: use string interpolation to make code clear
                // records = Reader.GetTotal(Path.pathConstructor(directory + "//" + fileName)).Item2;
                var records = _dataProvider.GetResults();
                VerifyData(total, lvs, lts, ests, records);
            }
            else
            {
                var records = Result.CreateResults(total, lvs, lts, ests);
                // records = Result.CreateResults(total, lvs, lts, ests);
                // Writer.WriteToCSVFile(directory + "//" + fileName, records);
                _dataProvider.SetData(records);
                VerifyData(total, lvs, lts, ests, records);
            }
        }

        /// <summary>
        /// Compares the data from a given file with the previous import data
        /// </summary>
        /// <param name="total">total amount of users</param>
        /// <param name="lvs">total amount of users in LV</param>
        /// <param name="lts">total amount of users in LT</param>
        /// <param name="ests">total amount of users in EE</param>
        /// <param name="records">The data from the previous import</param>
        //TODO: Look like this is private method. Do we really need to export it?
        private void VerifyData(int total, int lvs, int lts, int ests, List<Result> records)
        {
            foreach(var record in records)
            {
                if(total == record.Total && lvs == record.LV && lts == record.LT && ests == record.EE)
                {
                    Console.WriteLine("Records are being imported...");
                }
                else
                { 
                    throw new InvalidOperationException("User amounts do not match.");
                }
            }
        }
    }
}
