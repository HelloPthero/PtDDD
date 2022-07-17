using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PtDDD.Domain.IRepositories
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        #region 增加
        void Insert(TEntity entity);
        #endregion

        #region 删除
        void Delete(TPrimaryKey id);

        void Delete(TEntity entity);

        #endregion

        #region 改

        void Update(TEntity entity);

        //更新返回entity id 未实现
        #endregion


        #region 查

        TEntity Find(TPrimaryKey key);

        Task<int> CountAsync(); 
        #endregion


    }
}
