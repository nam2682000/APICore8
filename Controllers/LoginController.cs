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
            try
            {
                string token = await _loginService.Login(loginModel);
                return Ok(new { token = token });
            }
            catch (Exception ex) {
                return Unauthorized();
            }
        }
    }
}
