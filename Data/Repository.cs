using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TutorialHub.Data 
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _entities;
        string errorMessage = string.Empty;
 
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
 
        public T Get(long id)
        {
            return _entities.Find(id);
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Add(entity);
            _context.SaveChanges();
        }
 
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }
 
        public int Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Remove(entity);
            return _context.SaveChanges();
        }
    }
}