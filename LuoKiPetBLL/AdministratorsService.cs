using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class AdministratorsService:BaseServirce<Administrators>,IAdministratorsService
    {
        public AdministratorsService(IAdministratorsDal currentDal) : base(currentDal)
        {
        }
    }
}
