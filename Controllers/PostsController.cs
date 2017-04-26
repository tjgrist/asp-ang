using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TutorialHub.Models;
using TutorialHub.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace TutorialHub.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private IRepository<Post> _postsRepo;
        private UserManager<ApplicationUser> _userManager;
        private string GetUserId() => _userManager.GetUserId(User);
        private ApplicationDbContext _context;

        private string currentUserId;

        
        public PostsController(IRepository<Post> postsRepo, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _postsRepo = postsRepo;
            _userManager = userManager;
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Post> Get()
        {   
            return _postsRepo.GetAll();  
        }


        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetById(long id) 
        {
            var item = _postsRepo.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost("[action]")]
        public IActionResult Post([FromBody] Post post)
        {
            if (!ModelState.IsValid){
                return BadRequest();
            }
            post.Author = _context.Users.FirstOrDefault(u => u.Id == GetUserId());
            _postsRepo.Add(post);
            return CreatedAtRoute("GetPost", new { id = post.Id }, post);
            
        }


        [Authorize]
        [HttpGet("[action]")]
        public IEnumerable<Post> GetUserPosts()
        {
            currentUserId = GetUserId();
            return _postsRepo.GetAll().Where(p => p.Author.Id == currentUserId);
        }
  
    }
}