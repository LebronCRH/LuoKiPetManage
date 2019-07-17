using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class FindLostPet
    {
        public int FindLostId { get; set; }
        public string Fphone { get; set; }
        public string Fcontent { get; set; }
        public int? FuserId { get; set; }
        public int? ForLostId { get; set; }
    }
}
