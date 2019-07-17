using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class LostPet
    {
        public int LostId { get; set; }
        public DateTime? PubTime { get; set; }
        public int? PetCategoryId { get; set; }
        public int? Sex { get; set; }
        public int? HasBrand { get; set; }
        public string HairColor { get; set; }
        public string LostContent { get; set; }
        public int? Age { get; set; }
        public string PetName { get; set; }
        public string PubArea { get; set; }
        public string LostPic { get; set; }
        public DateTime? LostTime { get; set; }
        public string Lphone { get; set; }
        public string Ldescription { get; set; }
        public int? LostUserId { get; set; }
        public string Lname { get; set; }
        public int? Flag { get; set; }
        public int? PutUserId { get; set; }

        public User LostUser { get; set; }
        public PetCategory PetCategory { get; set; }
    }
}
