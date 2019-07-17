using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetInformationCollection
    {
        public int CollectionId { get; set; }
        public int? UserId { get; set; }
        public int? ArticleId { get; set; }
        public DateTime? Time { get; set; }

        public PetInformation Article { get; set; }
        public User User { get; set; }
    }
}
