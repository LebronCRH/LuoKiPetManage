using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Models;
using Models.DateTable;
using Models.LuoKiPetModels;
using LuoKiPetBLL;
using LuoKiPetIBLL;
using Web.Models.LayuiModel;
using Web.Models.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserInfoService _IUserInfoService;
        private IManageMenuService _IManageMenuService;
        private IManagerMenuChildService _IManagerMenuChildService;
        public HomeController(IUserInfoService service, IManageMenuService managemenuservice, IManagerMenuChildService managermenuchildservice)
        {
            _IUserInfoService = service;
            _IManageMenuService = managemenuservice;
            _IManagerMenuChildService = managermenuchildservice;
        }
        public IActionResult Index()
        {
            ManageMenuViewModel viewmodel = new ManageMenuViewModel();
            var menus = _IManageMenuService.LoadEntities(m => m.ManageMenuID > 0).ToList();
            viewmodel = GetAllManageMenu(menus);
            return View(viewmodel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ManageMenuViewModel GetAllManageMenu(List<ManageMenu> menus)
        {
            ManageMenuViewModel viewmodel = new ManageMenuViewModel();
            List<ManageMenuTree> menutrees = new List<ManageMenuTree>();
            foreach (var item in menus)
            {
                ManageMenuTree menutree = new ManageMenuTree();
                var menuchilds = _IManagerMenuChildService.LoadEntities(c => c.ForMenuID == item.ManageMenuID).ToList();
                menutree.menu = item;
                menutree.menuchilds = menuchilds;
                menutrees.Add(menutree);
            }
            viewmodel.menutrees = menutrees;
            return viewmodel;
        }
    }
}
