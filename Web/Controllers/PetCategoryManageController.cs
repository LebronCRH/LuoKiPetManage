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
    public class PetCategoryManageController : Controller
    {
        private IPetCategoryService _IPetCategoryService;
        public PetCategoryManageController(IPetCategoryService service)
        {
            _IPetCategoryService = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取所有的宠物种类数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public TableRespone<PetCategory> GetAllPetCategoryInfo(int page, int limit)
        {
            TableRespone<PetCategory> respone = new TableRespone<PetCategory>();
            try
            {
                var users = _IPetCategoryService.LoadEntitiesField(p =>p.PetCategoryId  != 0, m => new PetCategory { PetCategoryId = m.PetCategoryId, PetCategoryName = m.PetCategoryName, Intelligence = m.Intelligence, Height = m.Height, Shape = m.Shape, Weight = m.Weight, PetCategoryIntroduce = m.PetCategoryIntroduce, PetCategoryPhotos = m.PetCategoryPhotos,Alias=m.Alias,Origin=m.Origin,Price=m.Price,Function=m.Function,Hair=m.Hair,EnName=m.EnName,AniMalCategoryId=m.AniMalCategoryId }).OrderBy(p=>p.PetCategoryId);
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

        public TableRespone<PetCategory> GetSerachPetCategoryInfo(int page, int limit,string name,int category,string shape,string hair)
        {
            TableRespone<PetCategory> respone = new TableRespone<PetCategory>();
            try
            {
                var users = _IPetCategoryService.LoadEntitiesField(p => p.PetCategoryId != 0, m => new PetCategory { PetCategoryId = m.PetCategoryId, PetCategoryName = m.PetCategoryName, Intelligence = m.Intelligence, Height = m.Height, Shape = m.Shape, Weight = m.Weight, PetCategoryIntroduce = m.PetCategoryIntroduce, PetCategoryPhotos = m.PetCategoryPhotos, Alias = m.Alias, Origin = m.Origin, Price = m.Price, Function = m.Function, Hair = m.Hair, EnName = m.EnName, AniMalCategoryId = m.AniMalCategoryId });
                if (!string.IsNullOrEmpty(name))
                {
                    users = users.Where(p => p.PetCategoryName == name);
                }
                if (category>0)
                {
                    users = users.Where(p => p.AniMalCategoryId == category);
                }
                if (!string.IsNullOrEmpty(shape))
                {
                    users = users.Where(p => p.Shape == shape);
                }
                if (!string.IsNullOrEmpty(hair))
                {
                    users = users.Where(p => p.Hair == hair);
                }
                users = users.OrderBy(p => p.PetCategoryId);
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