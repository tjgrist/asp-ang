using System.Collections.Generic;
using TutorialHub.Models;
using TutorialHub.Data;
using TutorialHub.Interfaces;
using System.Linq;

namespace TutorialHub.Repository {


    public class PostsRepository : IPostsRepository{

        private readonly ApplicationDbContext _context;
        public PostsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public void Add(Post post) {
            //todo
        }

        public void Remove(long id) {
            //todo
        }

        public void Edit(Post post) {
            //todo
        }

        public IEnumerable<Post> GetAll() {

            return _context.Posts.ToList();
        }
    }
}