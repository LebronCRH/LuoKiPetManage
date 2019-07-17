using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class GetPet
    {
        public int GetId { get; set; }
        public DateTime? PubTime { get; set; }
        public int? PetCategoryId { get; set; }
        public int? Sex { get; set; }
        public int? HasInject { get; set; }
        public string HairColor { get; set; }
        public string GetContent { get; set; }
        public int? Age { get; set; }
        public string PubArea { get; set; }
        public string GetPic { get; set; }
        public string Feature { get; set; }
        public string Gname { get; set; }
        public string Gphone { get; set; }
        public string PetName { get; set; }
        public int? GetUserId { get; set; }
        public int? Flag { get; set; }
        public int? PutUserId { get; set; }

        public User GetUser { get; set; }
        public PetCategory PetCategory { get; set; }
    }
}
