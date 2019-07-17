using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class MemPet
    {
        public int MemId { get; set; }
        public string MemName { get; set; }
        public string MemAgent { get; set; }
        public string MemArea { get; set; }
        public string MemPhone { get; set; }
        public string MemPic { get; set; }
        public string MemGroup { get; set; }
        public string MemAffair { get; set; }
        public string MemPhoto { get; set; }
        public int? MemUserId { get; set; }

        public User MemUser { get; set; }
    }
}
