using System;

namespace TutorialHub.Models {


    public class Post {

        public int Id { get; set; }
        public string Body { get; set; }
        public int Views {get; set;}
        public DateTime Created { get; set; }
        
        // public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}