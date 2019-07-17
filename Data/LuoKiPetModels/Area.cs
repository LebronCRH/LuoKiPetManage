using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class Area
    {
        public Area()
        {
            PetServiceShop = new HashSet<PetServiceShop>();
            User = new HashSet<User>();
        }

        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int? AreaForCityId { get; set; }

        public City AreaForCity { get; set; }
        public ICollection<PetServiceShop> PetServiceShop { get; set; }
        public ICollection<User> User { get; set; }
    }
}
