using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class MpetServiceShopOrder
    {
        public int MshopServiceOrderId { get; set; }
        public int? ShopId { get; set; }
        public string ShopName { get; set; }
        public double? OrderTolatPrice { get; set; }
        public double? YouHuiQuan { get; set; }
        public double? BoQiBean { get; set; }
        public double? ActualPrice { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OrderState { get; set; }
        public int? CreateUserId { get; set; }
        public int? OrderServiceNum { get; set; }
        public string OrderNumber { get; set; }
        public string OrderUserPhone { get; set; }
        public string OrderVoucheCode { get; set; }
        public int? OrderUseState { get; set; }
    }
}
