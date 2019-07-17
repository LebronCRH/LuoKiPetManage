using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIDAL;

namespace LuoKiPetDAL
{
    public class ClassArticleDal:BaseDal<ClassArticle>,IClassArticleDal
    {
        public ClassArticleDal(LuoKiPetContext dbContext) : base(dbContext)
        {

        }
    }
}
