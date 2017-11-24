using System.Linq;
using HRIS.Model.Sys;
using System;

namespace HRIS.Service.Sys
{
    public interface IMenuService
    {
        void Create(MenuModel model, out Guid menuId);
        void Delete(Guid menuId);
        MenuModel GetById(Guid menuId);
        IQueryable<MenuModel> GetQuery();
        void Update(MenuModel model);
    }
}