using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models.LayuiModel;
using Models.LuoKiPetModels;
using LuoKiPetBLL;
using LuoKiPetIBLL;

namespace Web.Controllers
{
    public class UserManageController : Controller
    {
        private IUserInfoService _IUserInfoService;
        private IAdministratorsService _IAdministratorsService;
        public UserManageController(IUserInfoService service1, IAdministratorsService service2)
        {
            _IUserInfoService = service1;
            _IAdministratorsService = service2;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditUser(int userid)
        {
            User user = _IUserInfoService.LoadEntities(u => u.UserId == userid).FirstOrDefault();
            return View(user);
        }
        /// <summary>
        /// 更具是否管理员获取用户或管理员信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isManage"></param>
        /// <returns></returns>
        public object GetsUserOrManageInfo(int id, int isManage)
        {
            object user;
            if (isManage > 0)
            {
                user = _IAdministratorsService.LoadEntities(m => m.AdministratorsId == id).FirstOrDefault();
            }
            else {
                user = _IUserInfoService.LoadEntities(u => u.UserId == id).FirstOrDefault();
            }
            return user;
        }

        public TableRespone<User> GetAllUserInfo(int page, int limit)
        {
            TableRespone<User> respone = new TableRespone<User>();
            try
            {
                var users = _IUserInfoService.LoadEntities(u => u.UserId != 0).OrderBy(u=>u.UserId);
                respone.code = 0;
                respone.count = users.Count();
                respone.msg = "请求成功";
                respone.data = users.Skip(limit * (page - 1)).Take(limit).ToList();
                return respone;
            }
            catch (Exception e)
            {
                respone.code = 500;
                respone.count = 0;
                respone.msg = e.ToString();
                respone.data = null;
                return respone;
            }
        }
    }
}