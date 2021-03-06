using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Users.Tests
{
    [TestClass]
    public class PathConstructorTests
    {
        [TestMethod]
        public void CreatePath_PathReturned()
        {
            // arrange
            string fileName = "CSV//UserData.csv";

            // act
            PathConstructor path = new PathConstructor();
            string actual = path.pathConstructor(fileName);
            bool actualFlag = actual.Contains(fileName);

            // assert
            Assert.IsTrue(actualFlag);
        }
    }
}
