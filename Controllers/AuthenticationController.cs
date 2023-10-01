using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IConfiguration _IConfig;
        private IUser userprocess;
        public AuthenticationController(IConfiguration iConfig)
        {
            _IConfig = iConfig;
            userprocess = new UserRepository();
        }
        [HttpGet]
        public IActionResult register()
        {
            return View( new User());
        }
    }
}
