using HRIS.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service
{
    public class QueryGroupJoinedSysUser<TSource>
    {
        public TSource GroupSource { get; set; }
        public IEnumerable<sys_User> Users { get; set; }
    }
}
