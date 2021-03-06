using Microsoft.VisualStudio.TestTools.UnitTesting;
using Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        // [TestMethod()]
        // public void Compare_CreatedCSVandProvidedCSV()
        // {
        //     // arrange
        //     int id = 1;
        //     int total = 50;
        //     int LV = 30;
        //     int LT = 15;
        //     int EE = 5;
        //     List<Result> results = new List<Result>();
        //     Result r = new Result
        //     {
        //         Id = id,
        //         Total = total,
        //         LV = LV,
        //         LT = LT,
        //         EE = EE
        //     };
        //     results.Add(r);
        //
        //     // act
        //     CSVWriter writer = new CSVWriter();
        //     CSVReader reader = new CSVReader();
        //     PathConstructor path = new PathConstructor();
        //     Result result = new Result();
        //     Validator validator = new Validator(writer, reader, path, result);
        //
        //     // assert
        //     try
        //     {
        //         validator.VerifyData(total, LV, LT, EE, results);
        //         Assert.IsTrue(true);
        //     }
        //     catch
        //     {
        //         Assert.IsTrue(false);
        //     }
        // }

        [TestMethod()]
        public void Validate_CSV()
        {
            // arrange
            int total = 50;
            int LV = 30;
            int LT = 15;
            int EE = 5;
            string directory = "CSV";
            string fileName = "UserCount.csv";

            // act
            CSVWriter writer = new CSVWriter();
            CSVReader reader = new CSVReader($"{directory}//{fileName}".ToCsvFilePath());
            PathConstructor path = new PathConstructor();
            Result result = new Result();
            Validator validator = new Validator(writer, reader, path, result);

            // assert
            try
            {
                validator.ValidateFile(directory,fileName,total,LV,LT,EE);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}