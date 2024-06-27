using Microsoft.AspNetCore.Mvc;
using MyApp.Model;
using MyApp.Service;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel loginModel)
        {
            string token = await _loginService.Login(loginModel);
            return Ok(token);
        }
    }
}
