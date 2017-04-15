using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBasic.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
