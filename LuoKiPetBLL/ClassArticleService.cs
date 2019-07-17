using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class ClassArticleService:BaseServirce<ClassArticle>,IClassArticleService
    {
        public ClassArticleService(IClassArticleDal currentDal) : base(currentDal)
        {
        }
    }
}
