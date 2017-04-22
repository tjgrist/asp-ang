using TutorialHub.Models;
using System.Collections.Generic;

namespace TutorialHub.Data 
{
    public interface IUserRepository
    {
        ApplicationUser GetCurrentUser(string id);
        IEnumerable<Post> GetUserPosts(string id);
    }
}