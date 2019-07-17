using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.LuoKiPetModels;

namespace Web.Models.ViewModels
{
    public class TableMenuViewModel
    {
        public List<MenuJoinChild> menujoinchildlist { get; set; }
    }
    public class MenuJoinChild
    {
        public ManageMenu menu { get; set; }
        public ManagerMenuChild child { get; set; }
    }
}
