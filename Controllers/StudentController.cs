using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Database;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private ApplicationDbContext _context;
        public StudentController(ILogger<StudentController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var data = await _context.Students.FirstOrDefaultAsync();
            return Ok(data);
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> GetAll1()
        {
            return Ok("User");
        }
    }
}
