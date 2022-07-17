using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PtDDD.Domain.IRepositories
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        #region 增
        void Insert(TEntity entity);
        #endregion

        #region 删
        void Delete(TPrimaryKey id);

        void Delete(TEntity entity);

        #endregion

        #region 改

        void Update(TEntity entity);

        //更新返回entity id 未实现
        #endregion


        #region 查

        TEntity Find(TPrimaryKey key);

        TEntity Find(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> ALL();
        IQueryable<TEntity> ALL(Expression<Func<TEntity, bool>> predicate); 




        Task<int> CountAsync(); 
        #endregion


    }
}
