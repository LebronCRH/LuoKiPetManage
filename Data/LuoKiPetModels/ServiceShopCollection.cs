using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ServiceShopCollection
    {
        public int CollectionId { get; set; }
        public int? UserId { get; set; }
        public int? ShopId { get; set; }
        public DateTime? Time { get; set; }

        public PetServiceShop Shop { get; set; }
        public User User { get; set; }
    }
}
