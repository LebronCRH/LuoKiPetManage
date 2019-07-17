using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.LayuiModel
{
    public class CascadeSelect
    {
        public IList<CascadeItem> CascadeItemList { get; set; }
    }
    public class CascadeItem
    {
        public string code { get; set; }
        public string name { get; set; }
        public IList<CascadeItem> childs { get; set; }
    }
}
