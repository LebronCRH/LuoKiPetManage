using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class Commodity
    {
        public int CommodityId { get; set; }
        public int AnimalCategoryId { get; set; }
        public string CommodityName { get; set; }
        public decimal CommodityPrice { get; set; }
        public string CommoditySummary { get; set; }
        public string CommodityP1 { get; set; }
        public string CommodityP2 { get; set; }
        public string CommodityP3 { get; set; }
        public string CommodityP4 { get; set; }
        public string CommodityS1 { get; set; }
        public string CommodityS2 { get; set; }
        public string CommodityS3 { get; set; }
        public int? AnimalFengLeiId { get; set; }
        public string CommodityContent { get; set; }
    }
}
