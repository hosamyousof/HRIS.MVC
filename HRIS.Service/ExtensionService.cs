using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service
{
    public static class ExtensionService
    {
        public static IRepositoryQuery<TEntity> FilterCurrentCompany<TEntity>(this IRepositoryQuery<TEntity> rq) where TEntity : EntityBaseCompany
        {
            var bs = new BaseService();
            int companyId = bs.GetCurrentCompanyId();
            rq.Filter(x => x.companyId == companyId);
            return rq;
        }

        public static UpdateEntity<TModelSource, TModelDestination> SetCurrentCompany<TModelSource, TModelDestination>(this UpdateEntity<TModelSource, TModelDestination> ue) where TModelDestination : EntityBase
        {
            var bs = new BaseService();
            int companyId = bs.GetCurrentCompanyId();
            ue.SetValue("companyId", companyId);
            return ue;
        }

        public static UpdateEntity<TModelSource, TModelDestination> SetCurrentCompanyTo<TModelSource, TModelDestination, TProperty>(this UpdateEntity<TModelSource, TModelDestination> ue, Expression<Func<TModelDestination, TProperty>> destination) where TModelDestination : EntityBaseCompany
        {
            var bs = new BaseService();
            int companyId = bs.GetCurrentCompanyId();
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
            int userId = bs.GetCurrentUserId();
            ue.SetValue(destination, userId);
            return ue;
        }
    }
}