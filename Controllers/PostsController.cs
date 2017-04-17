using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TutorialHub.Models;
using TutorialHub.Data;
using TutorialHub.Interfaces;
using TutorialHub.Repository;

namespace WebApplicationBasic.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly IPostsRepository _postsRepository;
        
        public PostsController(IPostsRepository repo)
        {
            _postsRepository = repo;
        }

        [HttpGet("[action]")]
        public IEnumerable<Post> Get()
        {   
            return _postsRepository.GetAll();  
        }
  
    }
}