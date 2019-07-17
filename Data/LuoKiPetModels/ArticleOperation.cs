using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ArticleOperation
    {
        public int ArticleOperationId { get; set; }
        public int? UserId { get; set; }
        public int? ArticleId { get; set; }
        public int? ArticleCategoryId { get; set; }
        public int? Type { get; set; }
    }
}
