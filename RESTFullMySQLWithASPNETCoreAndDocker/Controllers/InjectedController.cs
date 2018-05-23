using RESTFullMySQLWithASPNETCoreAndDocker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Controllers
{
    public class InjectedController: ControllerBase
    {
        protected readonly StudentContext db;

        public InjectedController(StudentContext context)
        {
            db = context;
        }
        
    }
}