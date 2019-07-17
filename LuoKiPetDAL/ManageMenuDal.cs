using System;
using System.Collections.Generic;
using System.Text;
using LuoKiPetIDAL;
using Models.LuoKiPetModels;

namespace LuoKiPetDAL
{
    public class ManageMenuDal : BaseDal<ManageMenu>, IManageMenuDal
    {
        public ManageMenuDal(LuoKiPetContext dbContext) : base(dbContext)
        {
        }
        //实现自己特有的方法
    }
}
