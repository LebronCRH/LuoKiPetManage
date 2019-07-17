using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class FwshopComment
    {
        public int FwshopCommentId { get; set; }
        public int? CommentUserId { get; set; }
        public string CommentContent { get; set; }
        public double? Score { get; set; }
        public int? ForPackageId { get; set; }
        public int? ForShopId { get; set; }
        public int? ForServiceProjectId { get; set; }

        public User CommentUser { get; set; }
        public ProjectPackage ForPackage { get; set; }
        public ShopServiceProject ForServiceProject { get; set; }
        public PetServiceShop ForShop { get; set; }
    }
}
