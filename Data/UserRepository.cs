using TutorialHub.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TutorialHub.Data {

    public class UserRepository : IUserRepository 
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager )
        {
            _userManager = userManager;
            _context = context;
        }

        public ApplicationUser GetCurrentUser(string userId)
        {
            return _context.Users.SingleOrDefault(u => u.Id == userId);
        }

        public IEnumerable<Post> GetUserPosts(string userId) 
        {
            return _context.Posts.Where(p => p.Author.Id == userId);
        }   
    }
}