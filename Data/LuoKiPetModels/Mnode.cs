using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class Mnode
    {
        public int NodeId { get; set; }
        public string NodeName { get; set; }
        public int? ForAreaId { get; set; }
        public string FirstEn { get; set; }
        public int? ForCityId { get; set; }
    }
}
