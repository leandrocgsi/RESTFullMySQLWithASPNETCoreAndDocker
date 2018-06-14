using RESTFullMySQLWithASPNETCoreAndDocker.Model;
using System.IO;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Business.Implementattions
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {
            string path = Directory.GetCurrentDirectory();
            var fulPath = path + "\\Other\\aspnet-life-cycles-events.pdf";
            return File.ReadAllBytes(fulPath);
        }
    }
}
