using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class MservicePackage
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public double? Oldprice { get; set; }
        public double? Sprice { get; set; }
        public int? ForServiceId { get; set; }
    }
}
