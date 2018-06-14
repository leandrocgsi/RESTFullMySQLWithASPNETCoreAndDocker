using RESTFullMySQLWithASPNETCoreAndDocker.Model;
using System.Collections.Generic;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Business
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}
