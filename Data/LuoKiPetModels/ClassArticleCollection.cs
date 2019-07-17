using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ClassArticleCollection
    {
        public int CollectionId { get; set; }
        public int? UserId { get; set; }
        public int? ArticleId { get; set; }
        public DateTime? Time { get; set; }

        public ClassArticle Article { get; set; }
        public User User { get; set; }
    }
}
