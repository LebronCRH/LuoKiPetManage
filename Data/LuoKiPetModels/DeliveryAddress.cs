using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class DeliveryAddress
    {
        public int DeliveryAddressId { get; set; }
        public string DeliveryAddressName { get; set; }
        public string DeliveryAddressNumber { get; set; }
        public string DeliveryAddressZipcode { get; set; }
        public string DeliveryAddressRegion { get; set; }
        public string DeliveryAddressAddress { get; set; }
        public int? UserId { get; set; }
    }
}
