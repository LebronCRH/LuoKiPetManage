using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class PetInformationDal:BaseDal<PetInformation>,IPetInformationDal
    {
        public PetInformationDal(LuoKiPetContext dbContext) : base(dbContext)
        {

        }
    }
}
