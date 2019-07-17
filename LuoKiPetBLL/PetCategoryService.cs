using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class PetCategoryService:BaseServirce<PetCategory>,IPetCategoryService
    {
        public PetCategoryService(IPetCategoryDal currentDal) : base(currentDal)
        {
        }
    }
}
