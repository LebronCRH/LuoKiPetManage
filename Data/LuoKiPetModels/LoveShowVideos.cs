using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class LoveShowVideos
    {
        public int LoveShowVideoId { get; set; }
        public string LsvTitle { get; set; }
        public string LsvCotent { get; set; }
        public int LsvReleaseUserId { get; set; }
        public int LsvCategoryId { get; set; }
        public int? LsvBrowseNum { get; set; }
        public int? GiveZanNum { get; set; }
        public string LsvVideo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ArticleCategoryId { get; set; }

        public ArticleCategory ArticleCategory { get; set; }
    }
}
