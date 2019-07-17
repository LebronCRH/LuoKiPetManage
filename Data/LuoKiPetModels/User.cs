using System;
using System.Collections.Generic;

namespace Models.LuoKiPetModels
{
    public partial class User
    {
        public User()
        {
            ActiveWork = new HashSet<ActiveWork>();
            ClassArticle = new HashSet<ClassArticle>();
            ClassArticleCollection = new HashSet<ClassArticleCollection>();
            Comment = new HashSet<Comment>();
            FwshopComment = new HashSet<FwshopComment>();
            GetPet = new HashSet<GetPet>();
            LostPet = new HashSet<LostPet>();
            MemPet = new HashSet<MemPet>();
            PetInformation = new HashSet<PetInformation>();
            PetInformationCollection = new HashSet<PetInformationCollection>();
            PetRl = new HashSet<PetRl>();
            PetServiceCartDetails = new HashSet<PetServiceCartDetails>();
            PetServiceCarts = new HashSet<PetServiceCarts>();
            PetServiceOrder = new HashSet<PetServiceOrder>();
            PetServiceOrderDetails = new HashSet<PetServiceOrderDetails>();
            PickPet = new HashSet<PickPet>();
            ReplyReplyTarget = new HashSet<Reply>();
            ReplyReplyUser = new HashSet<Reply>();
            ServiceShopCollection = new HashSet<ServiceShopCollection>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Rpassword { get; set; }
        public int? Age { get; set; }
        public string Sex { get; set; }
        public string UserPhotos { get; set; }
        public string RegisterPhone { get; set; }
        public int? Identity { get; set; }
        public int? ForCityId { get; set; }
        public int? ForAreaId { get; set; }
        public double? UserBoQiMoney { get; set; }
        public string UserIntroduce { get; set; }
        public string Expertise { get; set; }
        public string QqaccessToken { get; set; }
        public string QqopenId { get; set; }
        public int? For_ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string AreaName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int UserState { get; set; }
        public DateTime? Disable { get; set; }

        public Area ForArea { get; set; }
        public City ForCity { get; set; }
        public ICollection<ActiveWork> ActiveWork { get; set; }
        public ICollection<ClassArticle> ClassArticle { get; set; }
        public ICollection<ClassArticleCollection> ClassArticleCollection { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<FwshopComment> FwshopComment { get; set; }
        public ICollection<GetPet> GetPet { get; set; }
        public ICollection<LostPet> LostPet { get; set; }
        public ICollection<MemPet> MemPet { get; set; }
        public ICollection<PetInformation> PetInformation { get; set; }
        public ICollection<PetInformationCollection> PetInformationCollection { get; set; }
        public ICollection<PetRl> PetRl { get; set; }
        public ICollection<PetServiceCartDetails> PetServiceCartDetails { get; set; }
        public ICollection<PetServiceCarts> PetServiceCarts { get; set; }
        public ICollection<PetServiceOrder> PetServiceOrder { get; set; }
        public ICollection<PetServiceOrderDetails> PetServiceOrderDetails { get; set; }
        public ICollection<PickPet> PickPet { get; set; }
        public ICollection<Reply> ReplyReplyTarget { get; set; }
        public ICollection<Reply> ReplyReplyUser { get; set; }
        public ICollection<ServiceShopCollection> ServiceShopCollection { get; set; }
    }
}
