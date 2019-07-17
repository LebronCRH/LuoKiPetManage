using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetProblem
    {
        public int PetProblemId { get; set; }
        public string Title { get; set; }
        public DateTime? PublishTime { get; set; }
        public int? CreateUserId { get; set; }
        public int? IsManage { get; set; }
        public string Content { get; set; }
        public int? CategoryId { get; set; }
        public int? BrowserNum { get; set; }
        public int? IsHot { get; set; }
    }
}
