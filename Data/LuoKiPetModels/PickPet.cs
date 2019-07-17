using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PickPet
    {
        public int PickId { get; set; }
        public DateTime? PubTime { get; set; }
        public int? PetCategoryId { get; set; }
        public int? Sex { get; set; }
        public int? HasBrand { get; set; }
        public string HairColor { get; set; }
        public string PickContent { get; set; }
        public string PubArea { get; set; }
        public string PickPic { get; set; }
        public int? PickUserId { get; set; }
        public string Piname { get; set; }
        public string Piphone { get; set; }
        public string Pidescription { get; set; }
        public DateTime? Pitime { get; set; }
        public int? Flag { get; set; }
        public int? PutUserId { get; set; }

        public PetCategory PetCategory { get; set; }
        public User PickUser { get; set; }
    }
}
