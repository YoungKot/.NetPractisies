using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class ResultMap : ClassMap<Result>
    {
        /// <summary>
        /// Maps the results from csv file to the proporties
        /// </summary>
        public ResultMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Total);
            Map(m => m.LV);
            Map(m => m.LT);
            Map(m => m.EE);
        }
    }
}
