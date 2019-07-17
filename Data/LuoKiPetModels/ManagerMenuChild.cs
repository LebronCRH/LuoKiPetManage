using System;
using System.Collections.Generic;
using System.Text;

namespace Models.LuoKiPetModels
{

    public partial class ManagerMenuChild
    {
        public int ManagerMenuChildID { get; set; }
        public string MenuChildName { get; set; }
        public string MenuChildHref { get; set; }
        public int? ForMenuID { get; set; }
        public string DataName { get; set; }
    }
}
