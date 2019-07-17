using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class MserviceShopOrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? PackageId { get; set; }
        public string PackageName { get; set; }
        public int? ServiceNum { get; set; }
        public double? OnePrice { get; set; }
        public int? ForOrderId { get; set; }
        public int? DetailsUserState { get; set; }
    }
}
