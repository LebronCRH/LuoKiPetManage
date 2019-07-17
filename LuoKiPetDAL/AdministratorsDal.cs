using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class AdministratorsDal:BaseDal<Administrators>,IAdministratorsDal
    {
        public AdministratorsDal(LuoKiPetContext dbContext) : base(dbContext)
        { }
    }
}
