using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class PetInformationService:BaseServirce<PetInformation>,IPetInformationService
    {
        public PetInformationService(IPetInformationDal currentDal) : base(currentDal)
        {
        }
    }
}
