using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class PetDiseaseDal:BaseDal<PetDisease>,IPetDiseaseDal
    {
        public PetDiseaseDal(LuoKiPetContext dbContext) : base(dbContext)
        {
        }
    }
}
