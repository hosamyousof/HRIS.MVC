using HRIS.Model.Sys;
using System;
using System.Linq;

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