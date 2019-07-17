using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ArticleCategory
    {
        public ArticleCategory()
        {
            LoveShowPhotos = new HashSet<LoveShowPhotos>();
            LoveShowVideos = new HashSet<LoveShowVideos>();
        }

        public int ArticleCategoryId { get; set; }
        public string ArticleNmae { get; set; }

        public ICollection<LoveShowPhotos> LoveShowPhotos { get; set; }
        public ICollection<LoveShowVideos> LoveShowVideos { get; set; }
    }
}
