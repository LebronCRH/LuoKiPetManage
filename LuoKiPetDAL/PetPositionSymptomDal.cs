using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class PetPositionSymptomDal:BaseDal<PetPositionSymptom>,IPetPositionSymptomDal
    {
        public PetPositionSymptomDal(LuoKiPetContext dbContext) : base(dbContext)
        {
        }
    }
}
