﻿using HRIS.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service
{
    public class QueryGroupJoinedSelectManySysUser<TSource>
    {
        public QueryGroupJoinedSysUser<TSource> Source { get; set; }
        public sys_User User { get; set; }
    }
}
