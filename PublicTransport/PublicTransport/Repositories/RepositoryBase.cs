using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PublicTransport.Models;
namespace PublicTransport.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PublicContext PublicContext { get; set; }

        public RepositoryBase(PublicContext publicContext)
        {
            this.PublicContext = publicContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.PublicContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.PublicContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.PublicContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.PublicContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.PublicContext.Set<T>().Remove(entity);
        }
    }
}
