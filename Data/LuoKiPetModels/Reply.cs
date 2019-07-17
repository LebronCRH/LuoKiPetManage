using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class Reply
    {
        public int ReplyId { get; set; }
        public int? ReplyTargetId { get; set; }
        public int? ReplyUserId { get; set; }
        public DateTime? ReplayTime { get; set; }
        public int? ReplyCommentId { get; set; }
        public string ReplyContent { get; set; }

        public Comment ReplyComment { get; set; }
        public User ReplyTarget { get; set; }
        public User ReplyUser { get; set; }
    }
}
