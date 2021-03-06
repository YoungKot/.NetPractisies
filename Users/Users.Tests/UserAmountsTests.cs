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
    public class UserAmountsTests
    {
        [TestMethod()]
        public void Get_TotalUsers_CountReturned()
        {
            // arrange
            List<User> users = new List<User>();
            string fileName = "CSV//UserData.csv";
            int expected = 50;
            
            // act
            PathConstructor path = new PathConstructor();
            CSVReader reader = new CSVReader(fileName.ToCsvFilePath());
            UserAmounts amount = new UserAmounts();
            users = reader.GetUsers();
            int actual = amount.GetTotalUsersCount(users);
            
            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Get_UsersByCountry_CountReturned()
        {
            // arrange
            List<User> users = new List<User>();
            string fileName = "CSV//UserData.csv";
            string country = "LV";
            int expected = 30;

            // act
            PathConstructor path = new PathConstructor();
            CSVReader reader = new CSVReader(fileName.ToCsvFilePath());
            UserAmounts amount = new UserAmounts();
            users = reader.GetUsers();
            int actual = amount.GetUsersByCountryCount(country,users);
            
            // assert
            Assert.AreEqual(actual, expected);
        }
    }
}