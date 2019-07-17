using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class SupportWork
    {
        public int SupportWorkId { get; set; }
        public int? SupportUserId { get; set; }
        public int? ForWorkId { get; set; }

        public ActiveWork ForWork { get; set; }
    }
}
