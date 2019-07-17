using System;
using System.Collections.Generic;
using System.Text;
using LuoKiPetIDAL;
using Models.LuoKiPetModels;

namespace LuoKiPetDAL
{
    public class PetCategoryDal:BaseDal<PetCategory>,IPetCategoryDal
    {
        public PetCategoryDal(LuoKiPetContext dbContext) : base(dbContext)
        {
        }
        //实现自己特有的方法
    }
}
