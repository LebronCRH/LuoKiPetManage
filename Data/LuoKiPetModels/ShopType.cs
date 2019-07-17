using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ShopType
    {
        public int ShopTypeId { get; set; }
        public string TypeName { get; set; }
        public double? ShopPrice { get; set; }
        public double? MarkPrice { get; set; }
        public int? ForShopId { get; set; }

        public LuoKiShop ForShop { get; set; }
    }
}
