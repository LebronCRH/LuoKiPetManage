using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ActiveWork
    {
        public ActiveWork()
        {
            SupportWork = new HashSet<SupportWork>();
        }

        public int ActiveWorkId { get; set; }
        public int? WorkUserId { get; set; }
        public string Photo { get; set; }
        public string Introduce { get; set; }
        public int? ForActiveId { get; set; }
        public DateTime? WorkTime { get; set; }
        public int? SupportNum { get; set; }
        public string WorkUserName { get; set; }

        public User WorkUser { get; set; }
        public ICollection<SupportWork> SupportWork { get; set; }
    }
}
