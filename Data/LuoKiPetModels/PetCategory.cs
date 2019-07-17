using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetCategory
    {
        public PetCategory()
        {
            GetPet = new HashSet<GetPet>();
            LostPet = new HashSet<LostPet>();
            PickPet = new HashSet<PickPet>();
        }

        public int PetCategoryId { get; set; }
        public string PetCategoryName { get; set; }
        public string Alias { get; set; }
        public string Shape { get; set; }
        public string Hair { get; set; }
        public string EnName { get; set; }
        public string Intelligence { get; set; }
        public string Origin { get; set; }
        public string Weight { get; set; }
        public string Price { get; set; }
        public string Height { get; set; }
        public string HairColor { get; set; }
        public string Function { get; set; }
        public int? TasteLevel { get; set; }
        public int? ExerciseLevel { get; set; }
        public int? HeatResistance { get; set; }
        public int? GuJiaLevel { get; set; }
        public int? ColdResistance { get; set; }
        public int? AppearanceLevel { get; set; }
        public int? FriendlyLevel { get; set; }
        public int? GluttonousLevel { get; set; }
        public int? StickyLevel { get; set; }
        public int? HairfallingLevel { get; set; }
        public int? CallLevel { get; set; }
        public int? CanTrainLevel { get; set; }
        public int? FeedDifficulty { get; set; }
        public int? CareNeeds { get; set; }
        public string BaseInfo { get; set; }
        public string VarietyCharact { get; set; }
        public string NursKnowledge { get; set; }
        public string NeedCare { get; set; }
        public int? AniMalCategoryId { get; set; }
        public string PetCategoryPhotos { get; set; }
        public string PetCategoryIntroduce { get; set; }

        public AnimalCategory AniMalCategory { get; set; }
        public ICollection<GetPet> GetPet { get; set; }
        public ICollection<LostPet> LostPet { get; set; }
        public ICollection<PickPet> PickPet { get; set; }
    }
}
