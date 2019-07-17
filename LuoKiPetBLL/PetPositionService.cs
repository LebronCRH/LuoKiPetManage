using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class PetPositionService:BaseServirce<PetPosition>,IPetPositionService
    {
        public PetPositionService(IPetPositionDal currentDal) : base(currentDal)
        {
        }
    }
}
