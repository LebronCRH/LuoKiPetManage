using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models.LayuiModel;
using LuoKiPetIBLL;
using Web.Models.ViewModels;
using Models.LuoKiPetModels;

namespace Web.Controllers
{
    public class ManageMenuController : Controller
    {
        private IManageMenuService _IManageMenuService;
        private IManagerMenuChildService _IManagerMenuChildService;
        public ManageMenuController(IManageMenuService managemenuservice, IManagerMenuChildService managermenuchildservice)
        {
            _IManageMenuService = managemenuservice;
            _IManagerMenuChildService = managermenuchildservice;
        }
        public IActionResult Index()
        {
            var menus = _IManageMenuService.LoadEntities(m => m.ManageMenuID > 0).ToList();
            return View(menus);
        }

        public IActionResult EditMenuChild(int childid)
        {
            var menuchild = _IManagerMenuChildService.LoadEntities(c => c.ManagerMenuChildID == childid).FirstOrDefault();
            var menus = _IManageMenuService.LoadEntities(m => m.ManageMenuID > 0).ToList();
            EditMenuChildViewModel viewmodel = new EditMenuChildViewModel()
            {
                menulist=menus,
                menuchild=menuchild,
            };
            return View(viewmodel);
        }

        public IActionResult AddMenuChild()
        {
            var menus = _IManageMenuService.LoadEntities(m => m.ManageMenuID > 0).ToList();
            ManagerMenuChild menuchild = new ManagerMenuChild();
            EditMenuChildViewModel viewmodel = new EditMenuChildViewModel()
            {
                menulist = menus,
                menuchild = menuchild,
            };
            return View(viewmodel);
        }

        public IActionResult SelectLayuiIcon()
        {
            return View();
        }

        /// <summary>
        /// 更新单个节点
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdataMenuChild(ManagerMenuChild child)
        {
            try
            {
                return _IManagerMenuChildService.EditEntity(child) ? 1 : 0;
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// 批量删除子节点
        /// </summary>
        /// <param name="childlist"></param>
        /// <returns></returns>
        [HttpPost]
        public bool DeleteMenuChildList(List<ManagerMenuChild> childlist)
        {
            try
            {
                foreach (var childitem in childlist)
                {
                    _IManagerMenuChildService.DeleteEntity(childitem);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除单个节点
        /// </summary>
        /// <param name="childitem"></param>
        /// <returns></returns>
        [HttpPost]
        public bool DeleteMenuChildItem(ManagerMenuChild childitem)
        {
            try
            {
                 _IManagerMenuChildService.DeleteEntity(childitem);
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPost]
        public int UpdataMenu(ManageMenu menu)
        {
            try
            {
                return _IManageMenuService.EditEntity(menu) ? 1 : 0;
            }
            catch
            {
                return 0;
            }
        }
        [HttpPost]
        public int AddMenuChild(ManagerMenuChild child)
        {
            try
            {
                return _IManagerMenuChildService.AddEntity(child) != null ? 1 : 0;
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// 获得某个子菜单数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ManagerMenuChild GetMenuChildItem(int id)
        {
            var item = _IManagerMenuChildService.LoadEntities(c => c.ManagerMenuChildID == id).FirstOrDefault();
            return item;
        }
        /// <summary>
        /// 获取某个菜单栏数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ManageMenu GetMenuItem(int id)
        {
            var item = _IManageMenuService.LoadEntities(c => c.ManageMenuID == id).FirstOrDefault();
            return item;
        }

        /// <summary>
        /// 获取管理菜单栏的Layui的树形结构数据
        /// </summary>
        /// <returns></returns>
        public treeRespone GetManageMenuTree()
        {
            treeRespone treeres = new treeRespone();
            List<treeItem> TopBigTreeList = new List<treeItem>();
            treeItem TopTree = new treeItem()
            {
                name="菜单栏树形结构",
                spread=true,
                jibie=0,
            };
            var menus = _IManageMenuService.LoadEntities(m => m.ManageMenuID > 0).ToList();
            List<treeItem> BigtreeList = new List<treeItem>();
            foreach (var menuitem in menus)
            {
                treeItem treeitem = new treeItem()
                {
                    name=menuitem.MenuName,
                    id=menuitem.ManageMenuID,
                    spread=menuitem.ManageMenuID==2?true:false,
                    jibie=1,
                    menuicon=menuitem.MenuIcon,
                    dataname=menuitem.DataName,
                };
                var menuchilds = _IManagerMenuChildService.LoadEntities(c => c.ForMenuID == menuitem.ManageMenuID).ToList();
                List<treeItem> childtrees = new List<treeItem>();
                foreach (var childitem in menuchilds)
                {
                    treeItem treechilditem = new treeItem()
                    {
                        name = childitem.MenuChildName,
                        id=childitem.ManagerMenuChildID,
                        spread=false,
                        jibie=2,
                        forparentid=((Int32)childitem.ForMenuID).ToString(),
                        dataname=childitem.DataName,
                        linkhref=childitem.MenuChildHref,
                    };
                    childtrees.Add(treechilditem);
                }
                treeitem.children = childtrees;
                BigtreeList.Add(treeitem);
            }
            //treeres.tree = BigtreeList;
            TopTree.children = BigtreeList;
            TopBigTreeList.Add(TopTree);
            treeres.tree = TopBigTreeList;
            return treeres;
        }

        public TableRespone<MenuJoinChild> GetAllManageMenuTable(int page, int limit)
        {
            TableRespone<MenuJoinChild> respone = new TableRespone<MenuJoinChild>();
            try
            {
                List<MenuJoinChild> menuJoinChildrenlist = new List<MenuJoinChild>();
                var menus = _IManageMenuService.LoadEntities(m => m.ManageMenuID > 0).ToList();
                foreach (var menuitem in menus)
                {
                    var childs = _IManagerMenuChildService.LoadEntities(c => c.ForMenuID == menuitem.ManageMenuID).ToList();
                    foreach (var childitem in childs)
                    {
                        MenuJoinChild menujoinchilditem = new MenuJoinChild()
                        {
                            menu = menuitem,
                            child = childitem,
                        };
                        menuJoinChildrenlist.Add(menujoinchilditem);
                    }
                }
                respone.code = 0;
                respone.count = menuJoinChildrenlist.Count();
                respone.msg = "请求成功";
                respone.data = menuJoinChildrenlist.OrderBy(l=>l.child.ManagerMenuChildID).Skip(limit * (page - 1)).Take(limit).ToList();
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