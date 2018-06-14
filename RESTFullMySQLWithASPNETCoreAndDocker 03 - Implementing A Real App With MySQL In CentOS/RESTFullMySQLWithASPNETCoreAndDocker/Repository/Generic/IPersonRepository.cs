using RESTFullMySQLWithASPNETCoreAndDocker.Model;
using RESTFullMySQLWithASPNETCoreAndDocker.Model.Base;
using System.Collections.Generic;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Repository.Generic
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string fristName, string lastName);
    }
}
