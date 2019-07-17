using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class PetPositionSymptomService:BaseServirce<PetPositionSymptom>,IPetPositionSymptomService
    {
        public PetPositionSymptomService(IPetPositionSymptomDal currentDal) : base(currentDal)
        {
        }
    }
}
