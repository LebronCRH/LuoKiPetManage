using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class UserFriendly
    {
        public int FriendlyId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ToUserId { get; set; }
    }
}
