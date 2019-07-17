using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.LuoKiPetModels;

namespace Web.Models.LayuiModel
{
    public class TableRespone<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int count { get; set; }
        public IList<T> data { get; set; }
    }
}
