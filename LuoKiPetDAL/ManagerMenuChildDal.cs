using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class ManagerMenuChildDal:BaseDal<ManagerMenuChild>,IManagerMenuChildDal
    {
        public ManagerMenuChildDal(LuoKiPetContext dbContext) : base(dbContext)
        {
        }
    }
}
