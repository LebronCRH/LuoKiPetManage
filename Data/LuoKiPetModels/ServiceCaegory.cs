using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ServiceCaegory
    {
        public ServiceCaegory()
        {
            ShopServiceProject = new HashSet<ShopServiceProject>();
        }

        public int ServiceCategoryId { get; set; }
        public string ServiceCategoryName { get; set; }

        public ICollection<ShopServiceProject> ShopServiceProject { get; set; }
    }
}
