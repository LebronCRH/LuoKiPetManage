using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class FindPickPet
    {
        public int FindPickId { get; set; }
        public string Fphone { get; set; }
        public string Fcontent { get; set; }
        public int? FuserId { get; set; }
        public int? ForPickId { get; set; }
    }
}
