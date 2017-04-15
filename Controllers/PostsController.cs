using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBasic.Controllers
{
    [Route("/api/[controller]")]
    public class PostsController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<string> Get()
        {
            var strings = new string[]{ "hello", "world"};
            return strings;
        }
  
    }
}