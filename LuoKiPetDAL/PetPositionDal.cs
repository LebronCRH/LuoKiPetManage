using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class PetPositionDal:BaseDal<PetPosition>,IPetPositionDal
    {
        public PetPositionDal(LuoKiPetContext dbContext) : base(dbContext)
        {
        }
    }
}
