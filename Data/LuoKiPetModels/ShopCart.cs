using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ShopCart
    {
        public int ShopCartId { get; set; }
        public int? ForUserId { get; set; }
        public int? ForShopId { get; set; }
        public string ShopNmae { get; set; }
        public double? ShopPrice { get; set; }
        public int? Amount { get; set; }
        public string ShopImage { get; set; }
    }
}
