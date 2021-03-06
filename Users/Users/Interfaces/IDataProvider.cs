using System.Collections.Generic;

namespace Users.Interfaces
{
    public interface IDataProvider
    {
        List<Result> GetResults();
        List<User> GetUsers();
        
        void SetData(List<Result> records);
    }
}