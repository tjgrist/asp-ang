using System.Collections.Generic;
using TutorialHub.Models;

namespace TutorialHub.Interfaces {

    public interface IPostsRepository {

        void Add(Post post);
        void Remove(long id);
        void Edit(Post post);
        IEnumerable<Post> GetAll();
    }
}