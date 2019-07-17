using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.LuoKiPetModels;

namespace Web.Models.LayuiModel
{
    public class treeRespone
    {
        public List<treeItem> tree { get; set; }
    }
    public class treeItem
    {
        public string name { get; set; }
        public bool spread { get; set; }
        public string href { get; set; }
        public List<treeItem> children { get; set; }//子节点
        public int id { get; set; }
        public int jibie { get; set; }//级别即层次结构
        public string forparentid { get; set; }//所属上级的id
        public string dataname { get; set; }//数据名称
        public string linkhref { get; set; }//子菜单的连接地址
        public string menuicon { get; set; }//父菜单的图标类型
    }
}
