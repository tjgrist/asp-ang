using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TutorialHub.Data 
{
    public interface IRepository<T> where T : class 
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);       
        void Update(T entity);
        int Delete(T entity);
    }
}