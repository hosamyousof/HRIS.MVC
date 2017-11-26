using HRIS.Data.Entity;
using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Migrations
{
    public static class MigrationExtentions
    {
        public static sys_RoleMenu AddChild(this sys_RoleMenu parent, Repository<sys_RoleMenu> repo, Action<List<sys_RoleMenu>> menuList)
        {
            var list = new List<sys_RoleMenu>();
            menuList(list);
            foreach (var item in list)
            {
                item.parentRoleMenuId = parent.id;
                repo.Insert(item);
            }
            return parent;
        }

        public static sys_RoleMenu AddListReturnValue(this List<sys_RoleMenu> the, sys_RoleMenu data)
        {
            the.Add(data);
            return data;
        }
    }
}