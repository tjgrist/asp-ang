using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using TutorialHub.Models;
using System;
using System.Threading.Tasks;
using TutorialHub.Data;
using System.Linq;

namespace TutorialHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        
    }
}
