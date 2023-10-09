using Microsoft.AspNetCore.Mvc;

namespace CursoCubits.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
