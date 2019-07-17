using System;
using System.Collections.Generic;
using System.Text;
using LuoKiPetIDAL;
using Models.LuoKiPetModels;

namespace LuoKiPetDAL
{
    public class UserInfoDal : BaseDal<User>, IUserInfoDal
    {
        public UserInfoDal(LuoKiPetContext dbContext):base(dbContext)
        {
        }
        //实现自己特有的方法
    }
}
