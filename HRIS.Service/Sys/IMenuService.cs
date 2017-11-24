using System.Linq;
using HRIS.Model.Sys;

namespace HRIS.Service.Sys
{
    public interface IMenuService
    {
        void Create(MenuModel model, out int menuId);
        void Delete(int menuId);
        MenuModel GetById(int menuId);
        IQueryable<MenuModel> GetQuery();
        void Update(MenuModel model);
    }
}