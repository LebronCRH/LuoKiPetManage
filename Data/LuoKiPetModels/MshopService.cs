using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class MshopService
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? SaleNum { get; set; }
        public double? OldPrice { get; set; }
        public double? MinPrice { get; set; }
        public int? ForServiceCateId { get; set; }
        public string ForServiceCateName { get; set; }
        public int? ForShopId { get; set; }
    }
}
