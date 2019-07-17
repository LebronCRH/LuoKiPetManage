using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DateTable
{
    public class DT_User
    {
        /// <summary>
        /// 默认int类型ID为主键
        /// 必须有一个字段为主键，不然会报错
        /// </summary>
        public int ID { get; set; }
        public string UserName { get; set; }
    }
}
