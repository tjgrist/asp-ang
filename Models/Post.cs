using System;
using System.Collections.Generic;
using System.Linq;

namespace TutorialHub.Models {


    public class Post {

        public int Id { get; set; }

        public string Body { get; set; }

        public int Views {get; set;}

        public DateTime Created { get; set; }
    }
}