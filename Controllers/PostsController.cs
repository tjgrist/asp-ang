using System;
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
        private string currentUserId;
        private string GetUserId() => _userManager.GetUserId(User);

        
        public PostsController(IRepository<Post> postsRepo, UserManager<ApplicationUser> userManager)
        {
            _postsRepo = postsRepo;
            _userManager = userManager;
        }

        [HttpGet("[action]")]
        public IEnumerable<Post> Get()
        {   
            return _postsRepo.GetAll();  
        }


        [Authorize]
        [HttpGet("[action]")]
        public IEnumerable<Post> GetUserPosts()
        {
            currentUserId = GetUserId();
            return _postsRepo.GetAll().Where(p => p.AuthorId == currentUserId);
        }
  
    }
}