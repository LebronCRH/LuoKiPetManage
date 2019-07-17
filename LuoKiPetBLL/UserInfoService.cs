using System;
using System.Collections.Generic;
using System.Text;
using Models.LuoKiPetModels;
using LuoKiPetIBLL;
using LuoKiPetIDAL;

namespace LuoKiPetBLL
{
    public class UserInfoService : BaseServirce<User>, IUserInfoService
    {
        public UserInfoService(IUserInfoDal currentDal):base(currentDal)
        {
        }
    }
}
