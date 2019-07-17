using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ReceivingAddress
    {
        public int AddressId { get; set; }
        public int? UserId { get; set; }
        public string Consignee { get; set; }
        public string ContactPhone { get; set; }
        public string Area { get; set; }
        public string DetailedNode { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? IsDefault { get; set; }
    }
}
