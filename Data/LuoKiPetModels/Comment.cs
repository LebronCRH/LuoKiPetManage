using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class Comment
    {
        public Comment()
        {
            Reply = new HashSet<Reply>();
        }

        public int CommentId { get; set; }
        public int? CommentTargetId { get; set; }
        public int? CommentUserId { get; set; }
        public DateTime? CommentTime { get; set; }
        public string CommentContent { get; set; }
        public int? CommentCategoryId { get; set; }

        public CommentCategory CommentCategory { get; set; }
        public User CommentUser { get; set; }
        public ICollection<Reply> Reply { get; set; }
    }
}
