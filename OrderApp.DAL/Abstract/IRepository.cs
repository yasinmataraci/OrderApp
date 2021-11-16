using OrderApp.Entities.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.DAL.Abstract
{
    public interface IRepository<T> where T: EntityBase, new()
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        T Find(Expression<Func<T, bool>> match);
    }
}
