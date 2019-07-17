using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class City
    {
        public City()
        {
            Area = new HashSet<Area>();
            PetServiceShop = new HashSet<PetServiceShop>();
            User = new HashSet<User>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public ICollection<Area> Area { get; set; }
        public ICollection<PetServiceShop> PetServiceShop { get; set; }
        public ICollection<User> User { get; set; }
    }
}
