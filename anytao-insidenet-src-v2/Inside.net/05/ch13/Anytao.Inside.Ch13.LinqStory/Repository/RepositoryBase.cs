// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Anytao.Inside.Ch13.LinqStory.Repository
{
    public abstract class RepositoryBase<TEntity, TDataConnector> : RepositoryBase, IRepositoryBase<TEntity>
        where TEntity : EntityBase<TEntity>
        where TDataConnector : IDataConnector<TEntity>
    {
        #region IRepositoryBase<TEntity> Members

        public IQueryable<TEntity> Loads()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Loads(Expression<Func<TEntity, bool>> predicate)
        {
            using (var ctx = GetDataConnector<TDataConnector>())
            {
                return ctx.GetObjectQuery<TEntity>().Where<TEntity>(predicate);
            }
        }

        public TEntity Load(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        // 省略其他
        #endregion
    }

    /// <summary>
    /// Repository base
    /// </summary>
    public abstract class RepositoryBase
    {
        #region Data Connector

        protected virtual TDataConnector GetDataConnector<TDataConnector>()
        {
            throw new NotImplementedException();
        }

        protected virtual TDataConnector GetDataConnector<TDataConnector>(string key)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
