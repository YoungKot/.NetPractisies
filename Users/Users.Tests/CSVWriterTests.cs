// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Users;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
//
// namespace Users.Tests
// {
//     [TestClass()]
//     public class CSVWriterTests
//     {
//         [TestMethod()]
//         public void Write_ResultsToCSV()
//         {
//             // arrange
//             int id = 1;
//             int total = 50;
//             int LV = 30;
//             int LT = 15;
//             int EE = 5;
//             string fileName = "CSV//UserCountCreatedByTest.csv";
//             List<Result> results = new List<Result>();
//             Result result = new Result
//             {
//                 Id = id,
//                 Total = total,
//                 LV = LV,
//                 LT = LT,
//                 EE = EE
//             };
//             results.Add(result);
//             var expected = results.Find(x => x.EE == 5);
//
//             // act
//             CSVReader reader = new CSVReader();
//             CSVWriter writer = new CSVWriter();
//             PathConstructor path = new PathConstructor();
//             var fullPath = path.pathConstructor(fileName);
//             writer.WriteToCSVFile(fullPath, results);
//             var actualList = reader.GetTotal(fullPath).Item2;
//             var actual = actualList.Find(x => x.EE == 5);
//             
//             // assert
//             Assert.AreEqual(actual.EE,expected.EE);
//         }
//     }
// }