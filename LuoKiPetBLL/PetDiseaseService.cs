using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class PetDiseaseService:BaseServirce<PetDisease>,IPetDiseaseService
    {
        public PetDiseaseService(IPetDiseaseDal currentDal) : base(currentDal)
        {
        }
    }
}
