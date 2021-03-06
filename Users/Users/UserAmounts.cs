using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class UserAmounts
    {
        private int count = 0;
        /// <summary>
        /// Converts total users to the number
        /// </summary>
        /// <param name="list"> list with the users</param>
        /// <returns>Returns total users count</returns>
        //TODO: Just one usage. Do we really need this method? It doesn't do anything but just returns count from the list
        public int GetTotalUsersCount(List<User> list)
        {   
            int totalUsers = list.Count;
            return totalUsers;
        }

        /// <summary>
        /// Filters the total users based on the country and converts to the number
        /// </summary>
        /// <param name="country">country code</param>
        /// <param name="list">the list of users</param>
        /// <returns>Returns total users by country count</returns>
        public int GetUsersByCountryCount(string country, List<User> list)
        {
            int userByCountry = list.Where(s => s.Country.Contains(country)).Count();
            return userByCountry;
        }
    }
    
    public static class UserAmountsStatic
    {
        public static int GetUsersByCountryCount(this List<User> list,string country)
        {   
            int userByCountry = list.Count(s => s.Country.Contains(country));
            return userByCountry;
        }

    }
}
