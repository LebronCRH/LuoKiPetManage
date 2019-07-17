using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class ManagerMenuChildService:BaseServirce<ManagerMenuChild>,IManagerMenuChildService
    {
        public ManagerMenuChildService(IManagerMenuChildDal currentDal) : base(currentDal)
        {

        }
    }
}
