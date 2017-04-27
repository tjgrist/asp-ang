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
        private IRepository<Post> _postsRepository;
        private UserManager<ApplicationUser> _userManager;
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        
        public PostsController(IRepository<Post> postsRepository, UserManager<ApplicationUser> userManager)
        {
            _postsRepository = postsRepository;
            _userManager = userManager;
        }

        [HttpGet("[action]")]
        public IEnumerable<Post> Get()
        {   
            return _postsRepository.GetAll();  
        }


        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetById(long id) 
        {
            var item = _postsRepository.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Post([FromBody] Post post)
        {
            if (!ModelState.IsValid){
                return BadRequest();
            }
            post.Author = await GetCurrentUserAsync();
            _postsRepository.Add(post);
            return CreatedAtRoute("GetPost", new { id = post.Id }, post);
            
        }


        [Authorize]
        [HttpGet("[action]")]
        public async Task<IEnumerable<Post>> GetUserPosts()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            return _postsRepository.GetAll().Where(p => p.Author ==  user);
        }
  
    }
}