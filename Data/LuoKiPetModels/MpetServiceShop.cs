using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class MpetServiceShop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopImg { get; set; }
        public string Address { get; set; }
        public string Node { get; set; }
        public string BusinessHours { get; set; }
        public string Car { get; set; }
        public string WiFi { get; set; }
        public double? MinPrice { get; set; }
        public int? SaleNum { get; set; }
        public string ShopIntroduce { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
        public double? Evaluate { get; set; }
        public double? Distance { get; set; }
        public int? ForCityId { get; set; }
        public int? ForAreaId { get; set; }
        public int? ForNodeId { get; set; }
        public string ShopPhone { get; set; }
    }
}
