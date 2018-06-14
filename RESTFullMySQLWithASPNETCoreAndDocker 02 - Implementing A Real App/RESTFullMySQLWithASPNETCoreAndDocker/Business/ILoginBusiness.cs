using RESTFullMySQLWithASPNETCoreAndDocker.Model;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Business
{
    public interface ILoginBusiness
    {
         object FindByLogin(UserVO user);
    }
}
