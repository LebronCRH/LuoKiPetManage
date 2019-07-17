﻿using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class PetServiceCartDetails
    {
        public int PetServiceCartDetailId { get; set; }
        public int? ForShopId { get; set; }
        public int? ForServiceProjectId { get; set; }
        public int? ForProjectPackageId { get; set; }
        public int? ForUserId { get; set; }
        public double? Price { get; set; }
        public int? Amount { get; set; }
        public string Detailed { get; set; }
        public int? ForPetServiceCartId { get; set; }

        public PetServiceCarts ForPetServiceCart { get; set; }
        public ProjectPackage ForProjectPackage { get; set; }
        public ShopServiceProject ForServiceProject { get; set; }
        public PetServiceShop ForShop { get; set; }
        public User ForUser { get; set; }
    }
}