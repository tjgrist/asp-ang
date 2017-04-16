using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TutorialHub.Models;
using TutorialHub.Data;

namespace WebApplicationBasic.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Post> Get()
        {   
            return _context.Posts.ToList();  
        }
  
    }
}