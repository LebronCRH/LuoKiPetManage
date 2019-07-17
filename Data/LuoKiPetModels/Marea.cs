using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class Marea
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int? ForCityId { get; set; }
        public string AreaEn { get; set; }
    }
}
