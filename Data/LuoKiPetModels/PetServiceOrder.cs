using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetServiceOrder
    {
        public int PetServiceOrderId { get; set; }
        public int? ForUserId { get; set; }
        public int? ForShopId { get; set; }
        public int? OrderState { get; set; }
        public string OrderNumber { get; set; }
        public double? OrderTotalMoney { get; set; }
        public string OrderCode { get; set; }
        public string OrderContactPhone { get; set; }
        public int? OrderServiceNum { get; set; }
        public DateTime? OrderTime { get; set; }

        public PetServiceShop ForShop { get; set; }
        public User ForUser { get; set; }
    }
}
