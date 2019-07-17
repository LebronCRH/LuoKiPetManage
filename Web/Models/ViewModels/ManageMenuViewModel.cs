using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.LuoKiPetModels;

namespace Web.Models.ViewModels
{
    public class ManageMenuViewModel
    {
        public List<ManageMenuTree> menutrees { get; set; }
    }

    public class EditMenuChildViewModel
    {
        public List<ManageMenu> menulist { get; set; }
        public ManagerMenuChild menuchild { get; set; }
    }

    public class ManageMenuTree
    {
        public ManageMenu menu { get; set; }
        public List<ManagerMenuChild> menuchilds { get; set; }
    }
}
