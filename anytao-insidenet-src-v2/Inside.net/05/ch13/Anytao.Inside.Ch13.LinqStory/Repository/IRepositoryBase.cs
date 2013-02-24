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
    public interface IRepositoryBase<TEntity> : IRepositoryBase where TEntity : EntityBase<TEntity>
    {
        IQueryable<TEntity> Loads();
        IQueryable<TEntity> Loads(Expression<Func<TEntity, bool>> predicate);

        TEntity Load(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

    public interface IRepositoryBase
    { }

}
