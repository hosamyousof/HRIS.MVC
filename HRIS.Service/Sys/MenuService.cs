using Common;
using HRIS.Data;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Sys
{
    public class MenuService : BaseService, IMenuService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<sys_Menu> _repoMenu;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCacheManager _memoryCacheManager;

        public MenuService(IUnitOfWork unitOfWork
            , IMemoryCacheManager memoryCacheManager
            , IEnumReferenceService enumReferenceService
            , IRepository<sys_Menu> repoMenu)
        {
            this._unitOfWork = unitOfWork;
            this._memoryCacheManager = memoryCacheManager;
            this._enumReferenceService = enumReferenceService;
            this._repoMenu = repoMenu;
        }

        public void Create(MenuModel model, out int menuId)
        {
            int currentUserId = this.GetCurrentUserId();

            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);

            var ins = this._repoMenu.PrepareEntity(model)
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, this.GetCurrentUserId())
                .Insert()
                .GetEntity();
            this._unitOfWork.Save();
            menuId = ins.id;
        }

        public void Delete(int menuId)
        {
            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);
            var data = this._repoMenu.Find(menuId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoMenu.Update(data);
            this._unitOfWork.Save();
        }

        public MenuModel GetById(int menuId)
        {
            return this.GetQuery().First(x => x.id == menuId);
        }

        public IQueryable<MenuModel> GetQuery()
        {
            var data = this._repoMenu
                .Query().Filter(x => x.deleted == false)
                .Get()
                .Select(x => new MenuModel()
                {
                    id = x.id,
                    description = x.description ?? "",
                    areaName = x.areaName,
                    actionName = x.actionName,
                    controllerName = x.controllerName,
                    parameter = x.parameter,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(MenuModel model)
        {
            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);
            this._repoMenu.FindAndUpdateFromModel(model, model.id)
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, this.GetCurrentUserId())
                .SetValue(x => x.updatedDate, DateTime.Now)
                .Update();

            this._unitOfWork.Save();
        }
    }
}