using Microsoft.EntityFrameworkCore;
using OrderApp.DAL.Abstract;
using OrderApp.Entities.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.DAL.Concrete
{
    public class Repository<T> : IRepository<T> where T : EntityBase, new()
    {
        private readonly OrderDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(OrderDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T Add(T entity)
        {
            T returnEntity = _dbSet.Add(entity).Entity;
            _context.SaveChanges();
            return returnEntity;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _dbSet.FirstOrDefault(match);
        }
    }
}
