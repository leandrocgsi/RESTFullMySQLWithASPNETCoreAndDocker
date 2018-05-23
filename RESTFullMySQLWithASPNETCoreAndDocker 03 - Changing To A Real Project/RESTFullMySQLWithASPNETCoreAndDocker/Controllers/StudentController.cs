using System.Threading.Tasks;
using RESTFullMySQLWithASPNETCoreAndDocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Controllers
{
    [Route("/api/[controller]")]
    public class StudentController: InjectedController
    {
        public StudentController(StudentContext context) : base(context) {}

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dept = await db.Departments.FindAsync(student.DepartmentID);
            if (dept == null)
            {
                ModelState.AddModelError("Department ID", $"Department {student.DepartmentID} does not exist");
                return BadRequest(ModelState);
            }
            await db.Students.AddAsync(student);
            await db.SaveChangesAsync();
            return Ok(new { StudentID = student.ID });
        }
        
    }
}