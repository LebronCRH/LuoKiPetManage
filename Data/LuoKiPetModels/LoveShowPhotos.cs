using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class LoveShowPhotos
    {
        public int LoveShowPhotoId { get; set; }
        public string LspTitle { get; set; }
        public string LspContent { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public int? LspCreateUserId { get; set; }
        public int? LspCategoryId { get; set; }
        public int? BrowseNum { get; set; }
        public int? GiveZanNum { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Image5 { get; set; }
        public string Image6 { get; set; }
        public int? ArticleCategoryId { get; set; }
        public string PhotoList { get; set; }

        public ArticleCategory ArticleCategory { get; set; }
    }
}
