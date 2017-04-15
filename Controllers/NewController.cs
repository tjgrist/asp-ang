using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBasic.Controllers
{
    [Route("api/[controller]")]
    public class NewController : Controller
    {

        [HttpGet("[action]")]
        public List<News> NewsCasts()
        {
            List<News> NewsCasts = new List<News>();
            for (var i = 0; i < 5; i ++ ){
                NewsCasts.Add(
                    new News {
                        Description = "some text here, today in the news something crazy happened.",
                        Time = DateTime.Now,
                        Views = 5
                    }
                );

            }
            return NewsCasts;
        }

        public class News {
            public string Description { get; set; }
            public int Views { get; set; }
            public DateTime Time { get; set; }
        }

    }

}