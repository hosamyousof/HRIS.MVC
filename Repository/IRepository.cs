using Repository.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Guid InstanceId { get; }

        void Delete(TEntity entity);

        void Delete(params object[] keyValues);

        TEntity Find(params object[] keyValues);

        UpdateEntity<TSource, TEntity> FindAndUpdateFromModel<TSource>(TSource source, params object[] keyValues);

        Task<TEntity> FindAsync(params object[] keyValues);

        Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues);

        IDataContext GetContext();

        TEntity Insert(TEntity entity);

        void InsertGraph(TEntity entity);

        void InsertGraphRange(IEnumerable<TEntity> entities);

        void InsertRange(IEnumerable<TEntity> entities);

        TEntity NewEntity(Action<UpdateEntity<string, TEntity>> config);

        UpdateEntity<string, TEntity> NewEntity();

        UpdateEntity<TSource, TEntity> PrepareEntity<TSource>(TSource source);

        IRepositoryQuery<TEntity> Query(bool includeDeleted = false);

        //IRepositoryQuery<TEntity> Query(Expression<Func<TEntity, bool>> filter, bool includeDeleted = false);

        IQueryable<TEntity> QueryGet(Expression<Func<TEntity, bool>> filter);

        IQueryable<TEntity> QueryGet();

        IRepositoryQuery<TEntity> QueryWithDeleted();

        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);

        void Update(TEntity entity);

        UpdateEntity<TSource, TEntity> UpdateFromModel<TSource>(TEntity entity, TSource source);
    }
}