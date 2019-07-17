using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class AppPetArticle
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleSubtitle { get; set; }
        public string ArticleCove { get; set; }
        public string ArticleContent { get; set; }
        public int? ArticleCreateUserId { get; set; }
        public int? ArticleCategoryId { get; set; }
        public DateTime? ArticlePublish { get; set; }
    }
}
