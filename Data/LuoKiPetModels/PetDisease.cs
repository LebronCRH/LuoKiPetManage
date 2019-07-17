using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetDisease
    {
        public int DiseaseId { get; set; }
        public string Genera { get; set; }
        public string Symptom { get; set; }
        public string Summary { get; set; }
        public string DiseaseCause { get; set; }
        public string MainSymptom { get; set; }
        public string Zdbz { get; set; }
        public string Treatment { get; set; }
        public string DiseaseName { get; set; }
        public int? ForPetCaegoryId { get; set; }
        public string ForEn { get; set; }
        public int? Type { get; set; }
        public int? ForSymptomId { get; set; }

        public PetPositionSymptom ForSymptom { get; set; }
    }
}
