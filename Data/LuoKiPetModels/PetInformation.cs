using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetInformation
    {
        public PetInformation()
        {
            PetInformationCollection = new HashSet<PetInformationCollection>();
        }

        public int PetInformationId { get; set; }
        public string Title { get; set; }
        public DateTime? PublishTime { get; set; }
        public string Photo { get; set; }
        public string Introduce { get; set; }
        public int? CreateUserId { get; set; }
        public int? IsManage { get; set; }
        public string Content { get; set; }
        public int? InfoCategoryId { get; set; }
        public int? BrowserNum { get; set; }
        public int? IsHot { get; set; }

        public User CreateUser { get; set; }
        public ICollection<PetInformationCollection> PetInformationCollection { get; set; }
    }
}
