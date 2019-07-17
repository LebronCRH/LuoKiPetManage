using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class CommentCategory
    {
        public CommentCategory()
        {
            Comment = new HashSet<Comment>();
        }

        public int CommentCategoryId { get; set; }
        public string CommentTargetName { get; set; }

        public ICollection<Comment> Comment { get; set; }
    }
}
