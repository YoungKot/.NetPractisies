using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Result
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int LV { get; set; }
        public int LT { get; set; }
        public int EE { get; set; }

        /// <summary>
        /// Creates the record with total amounts of users to be written to a the csv file
        /// </summary>
        /// <param name="total">total number of the users</param>
        /// <param name="lvs">total number of the users in LV</param>
        /// <param name="lts">total number of the users in LT</param>
        /// <param name="ests">total number of the users in EE</param>
        /// <returns>Returns the list of records</returns>
        //TODO: Clarify purpose of this method? 
        public List<Result> CreateResults(int total, int lvs, int lts, int ests)
        {  
            List<Result> records = new List<Result>
            {
                new Result { Id = 1 ,Total = total , LV = lvs , LT = lts , EE = ests },
            };

            return records;
        }
    }
}
