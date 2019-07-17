using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class ClassArticle
    {
        public ClassArticle()
        {
            ClassArticleCollection = new HashSet<ClassArticleCollection>();
        }

        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public DateTime? PublishTime { get; set; }
        public string Photo { get; set; }
        public string Introduce { get; set; }
        public int? CreateUserId { get; set; }
        public int? IsManager { get; set; }
        public string Content { get; set; }
        public int? ArticleCategoryId { get; set; }
        public int? BrowserNum { get; set; }
        public int? IsHot { get; set; }

        public User CreateUser { get; set; }
        public ICollection<ClassArticleCollection> ClassArticleCollection { get; set; }
    }
}
