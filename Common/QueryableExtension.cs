using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class QueryableExtension
    {
        public static TSource FirstOrDefaultInstance<TSource>(this IQueryable<TSource> source)
        {
            var data = source.FirstOrDefault();
            if (data == null)
                data = Activator.CreateInstance<TSource>();
            return data;
        }

        public static TSource FirstOrDefaultInstance<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            var data = source.FirstOrDefault(predicate);
            if (data == null)
                data = Activator.CreateInstance<TSource>();
            return data;
        }
    }
}