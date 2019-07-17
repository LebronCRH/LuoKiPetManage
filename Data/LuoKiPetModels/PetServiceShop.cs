using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetServiceShop
    {
        public PetServiceShop()
        {
            FwshopComment = new HashSet<FwshopComment>();
            PetServiceCartDetails = new HashSet<PetServiceCartDetails>();
            PetServiceCarts = new HashSet<PetServiceCarts>();
            PetServiceOrder = new HashSet<PetServiceOrder>();
            PetServiceOrderDetails = new HashSet<PetServiceOrderDetails>();
            ServiceShopCollection = new HashSet<ServiceShopCollection>();
            ShopServiceProject = new HashSet<ShopServiceProject>();
        }

        public int PetServiceShopId { get; set; }
        public string PetServiceShopName { get; set; }
        public string ShopPhone { get; set; }
        public string ShopAddress { get; set; }
        public string AddressJwd { get; set; }
        public string BusinessHours { get; set; }
        public int? HasBath { get; set; }
        public int? HasDesigner { get; set; }
        public int? HasFoster { get; set; }
        public int? HasMedicalCare { get; set; }
        public string ShopImage1 { get; set; }
        public string ShopImage2 { get; set; }
        public string ShopImage3 { get; set; }
        public string ShopImage4 { get; set; }
        public string ShopImage5 { get; set; }
        public string ShopImage6 { get; set; }
        public int? HasDogService { get; set; }
        public int? HasCatService { get; set; }
        public int? ForCityId { get; set; }
        public int? ForAreaId { get; set; }
        public int? ForUserId { get; set; }

        public Area ForArea { get; set; }
        public City ForCity { get; set; }
        public ICollection<FwshopComment> FwshopComment { get; set; }
        public ICollection<PetServiceCartDetails> PetServiceCartDetails { get; set; }
        public ICollection<PetServiceCarts> PetServiceCarts { get; set; }
        public ICollection<PetServiceOrder> PetServiceOrder { get; set; }
        public ICollection<PetServiceOrderDetails> PetServiceOrderDetails { get; set; }
        public ICollection<ServiceShopCollection> ServiceShopCollection { get; set; }
        public ICollection<ShopServiceProject> ShopServiceProject { get; set; }
    }
}
