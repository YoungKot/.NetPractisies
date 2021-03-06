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
//     public class CSVReaderTests
//     {
//         //TODO: Mock with file is not the best choice, however possible. Usage of repository and interfaces would make it unnecessary
//         [TestMethod()]
//         public void Read_CSV_UsersandResultsReturned()
//         {
//             // arrange
//             string fileName = "CSV//UserCount.csv";
//             List<Result> expectedResults = new List<Result>();
//             Result result = new Result
//             {
//                 Id = 1,
//                 Total = 50,
//                 LV = 30,
//                 LT = 15,
//                 EE = 5
//             };
//             expectedResults.Add(result);
//             var expected = expectedResults.Find(x => x.LV == 30);
//             
//             // act
//             PathConstructor path = new PathConstructor();
//             CSVReader reader = new CSVReader();
//             var actualResults = reader.GetTotal(path.pathConstructor(fileName)).Item2;
//             var actual = actualResults.Find(x => x.LV == 30);
//             
//             // assert
//             Assert.AreEqual(actual.LV, expected.LV);
//         }
//     }
// }