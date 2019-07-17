using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class ManageMenuService:BaseServirce<ManageMenu>,IManageMenuService
    {
        public ManageMenuService(IManageMenuDal currentDal) : base(currentDal)
        {

        }
    }
}
