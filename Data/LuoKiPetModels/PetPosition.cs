using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetPosition
    {
        public PetPosition()
        {
            PetPositionSymptom = new HashSet<PetPositionSymptom>();
        }

        public int PetPositionId { get; set; }
        public string PetPositionName { get; set; }
        public int? ForPetCategoryId { get; set; }

        public ICollection<PetPositionSymptom> PetPositionSymptom { get; set; }
    }
}
