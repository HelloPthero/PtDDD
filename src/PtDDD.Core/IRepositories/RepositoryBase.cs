using Microsoft.EntityFrameworkCore;
using PtDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PtDDD.Domain.IRepositories
{
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {

        private DBContext db;

        public RepositoryBase(DBContext db)
        {
            this.db = db;
        }

        public async Task<int> CountAsync()
        {
            return await db.Set<TEntity>().CountAsync();
        }

        public void Delete(TPrimaryKey id)
        {
            var entity = db.Users.Find(id);
            db.Users.Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public TEntity Find(TPrimaryKey id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate).First();
        }

        public void Insert(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate);
        }

        public IQueryable<TEntity> ALL()
        {
            return db.Set<TEntity>();
        }

        public IQueryable<TEntity> ALL(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate);
        }


    }
}
