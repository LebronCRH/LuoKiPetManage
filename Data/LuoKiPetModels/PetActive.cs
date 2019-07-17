using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetActive
    {
        public int PetActiveId { get; set; }
        public string Photo { get; set; }
        public string Content { get; set; }
        public DateTime? PetActiveTime { get; set; }
        public string ActiveTitle { get; set; }
    }
}
