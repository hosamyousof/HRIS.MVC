using HRIS.Data.Entity;
using Repository;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace HRIS.Service
{
    public static class ExtensionService
    {
        public static IRepositoryQuery<TEntity> FilterCurrentCompany<TEntity>(this IRepositoryQuery<TEntity> rq) where TEntity : EntityBaseCompany
        {
            var bs = new BaseService();
            Guid companyId = bs.GetCurrentCompanyId();
            rq.Filter(x => x.companyId == companyId);
            return rq;
        }

        public static UpdateEntity<TModelSource, TModelDestination> SetCurrentCompany<TModelSource, TModelDestination>(this UpdateEntity<TModelSource, TModelDestination> ue) where TModelDestination : EntityBase
        {
            var bs = new BaseService();
            Guid companyId = bs.GetCurrentCompanyId();
            ue.SetValue("companyId", companyId);
            return ue;
        }

        public static UpdateEntity<TModelSource, TModelDestination> SetCurrentCompanyTo<TModelSource, TModelDestination, TProperty>(this UpdateEntity<TModelSource, TModelDestination> ue, Expression<Func<TModelDestination, TProperty>> destination) where TModelDestination : EntityBaseCompany
        {
            var bs = new BaseService();
            Guid companyId = bs.GetCurrentCompanyId();
            ue.SetValue(destination, companyId);
            return ue;
        }

        public static UpdateEntity<TModelSource, TModelDestination> SetCurrentDateTo<TModelSource, TModelDestination, TProperty>(this UpdateEntity<TModelSource, TModelDestination> ue, Expression<Func<TModelDestination, TProperty>> destination) where TModelDestination : EntityBase
        {
            ue.SetValue(destination, DateTime.Now);
            return ue;
        }

        public static UpdateEntity<TModelSource, TModelDestination> SetCurrentUserTo<TModelSource, TModelDestination, TProperty>(this UpdateEntity<TModelSource, TModelDestination> ue, Expression<Func<TModelDestination, TProperty>> destination) where TModelDestination : EntityBase
        {
            var bs = new BaseService();
            Guid userId = bs.GetCurrentUserId();
            ue.SetValue(destination, userId);
            return ue;
        }

        public static IQueryable<QueryJoinedSysUser<TSource>> JoinSystemUser<TSource>(this IQueryable<TSource> query, Expression<Func<TSource, Guid>> outerSourceKeySelector)
        {
            var _repoUser = DependencyResolver.Current.GetService<IRepository<sys_User>>();
            return query
                .Join(_repoUser.QueryGet(), outerSourceKeySelector, u => u.id, (us, u) => new QueryJoinedSysUser<TSource>() { Source = us, User = u });
        }

        public static IQueryable<TResult> JoinSystemUser<TSource, TResult>(this IQueryable<TSource> query
            , Expression<Func<TSource, Guid>> outerSourceKeySelector
            , Expression<Func<TSource, sys_User, TResult>> resultSelector)
        {
            var _repoUser = DependencyResolver.Current.GetService<IRepository<sys_User>>();
            return query
                .Join(_repoUser.QueryGet(), outerSourceKeySelector, u => u.id, resultSelector);
        }

        public static IQueryable<QueryGroupJoinedSelectManySysUser<TSource>> LeftJoinSystemUser<TSource>(this IQueryable<TSource> query, Expression<Func<TSource, Guid?>> outerSourceKeySelector)
        {
            var _repoUser = DependencyResolver.Current.GetService<IRepository<sys_User>>();
            return query
                .GroupJoin(_repoUser.QueryGet(), outerSourceKeySelector, u => u.id, (groupCurrentUser, u) => new QueryGroupJoinedSysUser<TSource> { GroupSource = groupCurrentUser, Users = u })
                .SelectMany(x => x.Users.DefaultIfEmpty(), (currentUser, user) => new QueryGroupJoinedSelectManySysUser<TSource> { Source = currentUser, User = user });
        }

    }
}