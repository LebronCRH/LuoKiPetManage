using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ShopServiceProject
    {
        public ShopServiceProject()
        {
            FwshopComment = new HashSet<FwshopComment>();
            PetServiceCartDetails = new HashSet<PetServiceCartDetails>();
            PetServiceOrderDetails = new HashSet<PetServiceOrderDetails>();
            ProjectPackage = new HashSet<ProjectPackage>();
        }

        public int ShopServicesItemId { get; set; }
        public int? ForShopId { get; set; }
        public int? ServiceCategoryId { get; set; }
        public string ServiceItemName { get; set; }
        public int? SaleNum { get; set; }
        public double? MinPrice { get; set; }

        public PetServiceShop ForShop { get; set; }
        public ServiceCaegory ServiceCategory { get; set; }
        public ICollection<FwshopComment> FwshopComment { get; set; }
        public ICollection<PetServiceCartDetails> PetServiceCartDetails { get; set; }
        public ICollection<PetServiceOrderDetails> PetServiceOrderDetails { get; set; }
        public ICollection<ProjectPackage> ProjectPackage { get; set; }
    }
}
