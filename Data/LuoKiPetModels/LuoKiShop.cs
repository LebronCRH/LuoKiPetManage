using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class LuoKiShop
    {
        public LuoKiShop()
        {
            ShopType = new HashSet<ShopType>();
        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public double? ShopPrice { get; set; }
        public double? MarketPrice { get; set; }
        public string ShopBrand { get; set; }
        public string ShopIntroduce { get; set; }
        public string ShopGuiGe { get; set; }
        public string MainComponent { get; set; }
        public string FitPet { get; set; }
        public string VideoSrc { get; set; }
        public string ShopImg1 { get; set; }
        public string ShopImg2 { get; set; }
        public string ShopImg3 { get; set; }
        public string ShopImg4 { get; set; }
        public string ShopImg5 { get; set; }
        public byte[] ShopImg6 { get; set; }
        public string ShopBigIntro { get; set; }
        public int? ForPetCategory { get; set; }
        public int? ForShopCategory { get; set; }
        public int? SaleSum { get; set; }
        public string ShopUrl { get; set; }

        public ICollection<ShopType> ShopType { get; set; }
    }
}
