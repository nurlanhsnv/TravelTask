using CoreT.DataAccess.Abstract;
using CoreT.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CoreT.DataAccess.Concrete
{
    public class BaseRepository<TEntity, TContext>(TContext context) : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _context= context;
        public void Add(TEntity entity)
        {
            
                var addEntity = _context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            
        }

        public void Delete(TEntity entity)
        {
             
                var addEntity = _context.Entry(entity);
                addEntity.State = EntityState.Modified;
                context.SaveChanges();
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
       
            return _context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
           
            var updateEntity = _context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
