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
    public class ResultTests
    {
        [TestMethod()]
        public void Get_TotalandLVSandLTSandESTS_ResultListReturned()
        {
            // arrange
            int id = 1;
            int total = 50;
            int LV = 30;
            int LT = 15;
            int EE = 5;
            List<Result> expectedResults = new List<Result>();
            Result result = new Result
            {
                Id = id,
                Total = total,
                LV = LV,
                LT = LT,
                EE = EE
            };
            expectedResults.Add(result);
            var expected = expectedResults.Find(x => x.LT == 15);

            // act
            Result r = new Result();
            var actualList = r.CreateResults(total, LV, LT, EE);
            var actual = expectedResults.Find(x => x.LT == 15);
            
            // assert
            Assert.AreEqual(actual.LT, expected.LT);
        }
    }
}