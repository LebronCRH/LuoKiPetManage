using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuoKiPetIBLL;
using Web.Models.LayuiModel;
using Models.LuoKiPetModels;

namespace Web.Controllers
{
    public class PetArticleManageController : Controller
    {
        private IPetInformationService _IPetInformationService;
        private IClassArticleService _IClassArticleService;
        private IUserInfoService _IUserInfoService;
        private IAdministratorsService _IAdministratorsService;
        public PetArticleManageController(IPetInformationService service1, IClassArticleService service2, IAdministratorsService service3, IUserInfoService service4)
        {
            _IPetInformationService = service1;
            _IClassArticleService = service2;
            _IAdministratorsService = service3;
            _IUserInfoService = service4;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InformationArticle()
        {
            return View();
        }
        /// <summary>
        /// 获取所有发布的课堂知识文章
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public TableRespone<ClassArticle> GetAllClassArticleInfo(int page, int limit)
        {
            TableRespone<ClassArticle> respone = new TableRespone<ClassArticle>();
            try
            {
                //var users = _IClassArticleService.LoadEntitiesField(p => p.ArticleId != 0,p=>new ClassArticle { ArticleId=p.ArticleId, ArticleTitle =p.ArticleTitle , PublishTime =p.PublishTime , Photo =p.Photo , Introduce =p.Introduce , CreateUserId =p.CreateUserId , IsManager =p.IsManager , Content =p.Content , ArticleCategoryId =p.ArticleCategoryId , BrowserNum =p.BrowserNum ,IsHot=p.IsHot}).OrderByDescending(c=>c.PublishTime);
                var users = _IClassArticleService.LoadEntities(p => p.ArticleId != 0).OrderByDescending(c => c.PublishTime);
                foreach (var item in users)
                {
                    if (item.IsManager > 0)
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManager.ToString())) as Administrators).Name;
                    }
                    else
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManager.ToString())) as User).UserName;
                    }
                    item.CreateUser = null;
                }
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
        /// <summary>
        /// 课堂知识文章条件查询
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="title"></param>
        /// <param name="category"></param>
        /// <param name="datetime"></param>
        /// <param name="ismanage"></param>
        /// <returns></returns>
        public TableRespone<ClassArticle> GetSerachClassArticleInfo(int page, int limit, string title, string category, string datetime, string ismanage)
        {
            TableRespone<ClassArticle> respone = new TableRespone<ClassArticle>();
            try
            {
                var users = _IClassArticleService.LoadEntities(p => p.ArticleId != 0);
                if (!string.IsNullOrEmpty(title))
                {
                    users = users.Where(p => p.ArticleTitle.Contains(title));
                }
                if (!string.IsNullOrEmpty(category))
                {
                    users = users.Where(p => p.ArticleCategoryId == int.Parse(category));
                }
                if (!string.IsNullOrEmpty(datetime))
                {
                    var list = datetime.Split(" - ");
                    DateTime starttime =DateTime.Parse(list[0]);
                    DateTime endtime = DateTime.Parse(list[1]);
                    users = users.Where(p => p.PublishTime> starttime && p.PublishTime< endtime);
                }
                if (!string.IsNullOrEmpty(ismanage))
                {
                    users = users.Where(p => p.IsManager == int.Parse(ismanage));
                }
                foreach (var item in users)
                {
                    if (item.IsManager > 0)
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManager.ToString())) as Administrators).Name;
                    }
                    else
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManager.ToString())) as User).UserName;
                    }
                }
                users = users.OrderByDescending(p => p.PublishTime);
                foreach (var item in users.Skip(limit * (page - 1)).Take(limit))
                {
                    item.CreateUser = null;
                }
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

        /// <summary>
        /// 获取所有发布的宠物资讯文章
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public TableRespone<PetInformation> GetAllPetInformationInfo(int page, int limit)
        {
            TableRespone<PetInformation> respone = new TableRespone<PetInformation>();
            try
            {
                var users = _IPetInformationService.LoadEntities(p => p.PetInformationId != 0).OrderByDescending(c => c.PublishTime);
                foreach (var item in users)
                {
                    if (item.IsManage > 0)
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManage.ToString())) as Administrators).Name;
                    }
                    else
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManage.ToString())) as User).UserName;
                    }
                    item.CreateUser = null;
                }
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

        /// <summary>
        /// 资讯文章条件查询
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="title"></param>
        /// <param name="category"></param>
        /// <param name="datetime"></param>
        /// <param name="ismanage"></param>
        /// <returns></returns>
        public TableRespone<PetInformation> GetSerachPetInformationInfo(int page, int limit, string title, string category, string datetime, string ismanage)
        {
            TableRespone<PetInformation> respone = new TableRespone<PetInformation>();
            try
            {
                var users = _IPetInformationService.LoadEntities(p => p.PetInformationId != 0);
                if (!string.IsNullOrEmpty(title))
                {
                    users = users.Where(p => p.Title.Contains(title));
                }
                if (!string.IsNullOrEmpty(category))
                {
                    users = users.Where(p => p.InfoCategoryId == int.Parse(category));
                }
                if (!string.IsNullOrEmpty(datetime))
                {
                    var list = datetime.Split(" - ");
                    DateTime starttime = DateTime.Parse(list[0]);
                    DateTime endtime = DateTime.Parse(list[1]);
                    users = users.Where(p => p.PublishTime > starttime && p.PublishTime < endtime);
                }
                if (!string.IsNullOrEmpty(ismanage))
                {
                    users = users.Where(p => p.IsManage == int.Parse(ismanage));
                }
                foreach (var item in users)
                {
                    if (item.IsManage > 0)
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManage.ToString())) as Administrators).Name;
                    }
                    else
                    {
                        item.Content = (GetsUserOrManageInfo(int.Parse(item.CreateUserId.ToString()), int.Parse(item.IsManage.ToString())) as User).UserName;
                    }
                }
                users = users.OrderByDescending(p => p.PublishTime);
                foreach (var item in users.Skip(limit * (page - 1)).Take(limit))
                {
                    item.CreateUser = null;
                }
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

        public object GetsUserOrManageInfo(int id, int isManage)
        {
            object user;
            if (isManage > 0)
            {
                user = _IAdministratorsService.LoadEntities(m => m.AdministratorsId == id).FirstOrDefault();
            }
            else
            {
                user = _IUserInfoService.LoadEntities(u => u.UserId == id).FirstOrDefault();
            }
            return user;
        }
    }
}