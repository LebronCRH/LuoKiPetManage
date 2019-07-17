using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetServiceCarts
    {
        public PetServiceCarts()
        {
            PetServiceCartDetails = new HashSet<PetServiceCartDetails>();
        }

        public int PetServiceCartId { get; set; }
        public int? ForUserId { get; set; }
        public int? ForShopId { get; set; }
        public int? ServiceAmount { get; set; }

        public PetServiceShop ForShop { get; set; }
        public User ForUser { get; set; }
        public ICollection<PetServiceCartDetails> PetServiceCartDetails { get; set; }
    }
}
