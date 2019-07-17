using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class AnimalCategory
    {
        public AnimalCategory()
        {
            PetCategory = new HashSet<PetCategory>();
        }

        public int AnimalCategoryId { get; set; }
        public string AnimalCategoryName { get; set; }

        public ICollection<PetCategory> PetCategory { get; set; }
    }
}
