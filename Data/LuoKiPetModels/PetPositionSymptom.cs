using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetPositionSymptom
    {
        public PetPositionSymptom()
        {
            PetDisease = new HashSet<PetDisease>();
        }

        public int PetPositionSymptomId { get; set; }
        public string SymptomName { get; set; }
        public int? ForPetPositionId { get; set; }
        public string Describe { get; set; }

        public PetPosition ForPetPosition { get; set; }
        public ICollection<PetDisease> PetDisease { get; set; }
    }
}
