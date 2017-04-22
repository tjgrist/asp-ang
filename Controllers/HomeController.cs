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
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        private string GetUserId() => _userManager.GetUserId(User);

        public HomeController(UserManager<ApplicationUser> userManager, ApplicationDbContext context) 
        {
            _userManager = userManager;
            _context = context;
        }
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
