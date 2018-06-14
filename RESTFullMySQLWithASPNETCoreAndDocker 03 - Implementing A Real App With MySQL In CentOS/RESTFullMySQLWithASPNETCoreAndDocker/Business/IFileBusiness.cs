using RESTFullMySQLWithASPNETCoreAndDocker.Model;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Business
{
    public interface IFileBusiness
    {
         byte[] GetPDFFile();
    }
}
