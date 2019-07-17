using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ProjectPackage
    {
        public ProjectPackage()
        {
            FwshopComment = new HashSet<FwshopComment>();
            PetServiceCartDetails = new HashSet<PetServiceCartDetails>();
            PetServiceOrderDetails = new HashSet<PetServiceOrderDetails>();
        }

        public int ProjectPackageId { get; set; }
        public int? ForProjectId { get; set; }
        public double? Price { get; set; }
        public string PackgelName { get; set; }
        public int? ForShopId { get; set; }

        public ShopServiceProject ForProject { get; set; }
        public ICollection<FwshopComment> FwshopComment { get; set; }
        public ICollection<PetServiceCartDetails> PetServiceCartDetails { get; set; }
        public ICollection<PetServiceOrderDetails> PetServiceOrderDetails { get; set; }
    }
}
