using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
namespace Users
{
    public class UserMap : ClassMap<User>
    {   
        /// <summary>
        /// Maps the users from csv file to the proporties
        /// </summary>
        public UserMap()
        {
            Map(m => m.UserId).Name("UserId");
            Map(m => m.Country);
        }
    }
}
