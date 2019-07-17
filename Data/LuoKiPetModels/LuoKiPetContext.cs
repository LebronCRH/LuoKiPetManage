using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.LuoKiPetModels
{
    public partial class LuoKiPetContext : DbContext
    {
        public LuoKiPetContext()
        {
        }

        public LuoKiPetContext(DbContextOptions<LuoKiPetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveWork> ActiveWork { get; set; }
        public virtual DbSet<Administrators> Administrators { get; set; }
        public virtual DbSet<AnimalCategory> AnimalCategory { get; set; }
        public virtual DbSet<AnimalFengLei> AnimalFengLei { get; set; }
        public virtual DbSet<AppPetArticle> AppPetArticle { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<ArticleCategory> ArticleCategory { get; set; }
        public virtual DbSet<ArticleOperation> ArticleOperation { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClassArticle> ClassArticle { get; set; }
        public virtual DbSet<ClassArticleCollection> ClassArticleCollection { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentCategory> CommentCategory { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<DeliveryAddress> DeliveryAddress { get; set; }
        public virtual DbSet<EnCategory> EnCategory { get; set; }
        public virtual DbSet<FindLostPet> FindLostPet { get; set; }
        public virtual DbSet<FindPickPet> FindPickPet { get; set; }
        public virtual DbSet<FwshopComment> FwshopComment { get; set; }
        public virtual DbSet<GetPet> GetPet { get; set; }
        public virtual DbSet<LostPet> LostPet { get; set; }
        public virtual DbSet<LoveShowPhotos> LoveShowPhotos { get; set; }
        public virtual DbSet<LoveShowVideos> LoveShowVideos { get; set; }
        public virtual DbSet<LuoKiShop> LuoKiShop { get; set; }
        public virtual DbSet<Marea> Marea { get; set; }
        public virtual DbSet<Mcity> Mcity { get; set; }
        public virtual DbSet<MemPet> MemPet { get; set; }
        public virtual DbSet<Mnode> Mnode { get; set; }
        public virtual DbSet<MpetServiceShop> MpetServiceShop { get; set; }
        public virtual DbSet<MpetServiceShopOrder> MpetServiceShopOrder { get; set; }
        public virtual DbSet<MservicePackage> MservicePackage { get; set; }
        public virtual DbSet<MserviceShopOrderDetails> MserviceShopOrderDetails { get; set; }
        public virtual DbSet<MshopService> MshopService { get; set; }
        public virtual DbSet<MshopServiceCate> MshopServiceCate { get; set; }
        public virtual DbSet<PetActive> PetActive { get; set; }
        public virtual DbSet<PetCategory> PetCategory { get; set; }
        public virtual DbSet<PetDisease> PetDisease { get; set; }
        public virtual DbSet<PetInformation> PetInformation { get; set; }
        public virtual DbSet<PetInformationCollection> PetInformationCollection { get; set; }
        public virtual DbSet<PetPosition> PetPosition { get; set; }
        public virtual DbSet<PetPositionSymptom> PetPositionSymptom { get; set; }
        public virtual DbSet<PetProblem> PetProblem { get; set; }
        public virtual DbSet<PetRl> PetRl { get; set; }
        public virtual DbSet<PetServiceCartDetails> PetServiceCartDetails { get; set; }
        public virtual DbSet<PetServiceCarts> PetServiceCarts { get; set; }
        public virtual DbSet<PetServiceOrder> PetServiceOrder { get; set; }
        public virtual DbSet<PetServiceOrderDetails> PetServiceOrderDetails { get; set; }
        public virtual DbSet<PetServiceShop> PetServiceShop { get; set; }
        public virtual DbSet<PickPet> PickPet { get; set; }
        public virtual DbSet<ProjectPackage> ProjectPackage { get; set; }
        public virtual DbSet<ReceivingAddress> ReceivingAddress { get; set; }
        public virtual DbSet<Reply> Reply { get; set; }
        public virtual DbSet<ServiceCaegory> ServiceCaegory { get; set; }
        public virtual DbSet<ServiceShopCollection> ServiceShopCollection { get; set; }
        public virtual DbSet<ShopCart> ShopCart { get; set; }
        public virtual DbSet<ShopServiceProject> ShopServiceProject { get; set; }
        public virtual DbSet<ShopType> ShopType { get; set; }
        public virtual DbSet<SupportWork> SupportWork { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserFriendly> UserFriendly { get; set; }
        public virtual DbSet<ManageMenu> ManageMenu { get; set; }
        public virtual DbSet<ManagerMenuChild> ManagerMenuChild { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer("Server=.;Database=LuoKiPet;uid=sa;pwd=,.562437969crh");
            //            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveWork>(entity =>
            {
                entity.Property(e => e.ActiveWorkId).HasColumnName("ActiveWorkID");

                entity.Property(e => e.ForActiveId).HasColumnName("For_ActiveID");

                entity.Property(e => e.Introduce)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupportNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkUserId).HasColumnName("WorkUserID");

                entity.Property(e => e.WorkUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.WorkUser)
                    .WithMany(p => p.ActiveWork)
                    .HasForeignKey(d => d.WorkUserId)
                    .HasConstraintName("FK_ActiveWork_PetActive");
            });

            modelBuilder.Entity<Administrators>(entity =>
            {
                entity.Property(e => e.AdministratorsId).HasColumnName("AdministratorsID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimalCategory>(entity =>
            {
                entity.Property(e => e.AnimalCategoryId).HasColumnName("AnimalCategoryID");

                entity.Property(e => e.AnimalCategoryName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnimalFengLei>(entity =>
            {
                entity.Property(e => e.AnimalFengLeiId).HasColumnName("AnimalFengLei_ID");

                entity.Property(e => e.AnimalCategoryId).HasColumnName("AnimalCategoryID");

                entity.Property(e => e.AnimalFengLei1)
                    .IsRequired()
                    .HasColumnName("AnimalFengLei")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppPetArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.Property(e => e.ArticleId)
                    .HasColumnName("ArticleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.ArticleContent).IsUnicode(false);

                entity.Property(e => e.ArticleCove)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleCreateUserId).HasColumnName("ArticleCreateUserID");

                entity.Property(e => e.ArticlePublish).HasColumnType("datetime");

                entity.Property(e => e.ArticleSubtitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaForCityId).HasColumnName("AreaForCityID");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaForCity)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.AreaForCityId)
                    .HasConstraintName("FK_Area_City");
            });

            modelBuilder.Entity<ArticleCategory>(entity =>
            {
                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.ArticleNmae)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArticleOperation>(entity =>
            {
                entity.Property(e => e.ArticleOperationId).HasColumnName("ArticleOperationID");

                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClassArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.ArticleTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrowserNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.Introduce)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.ClassArticle)
                    .HasForeignKey(d => d.CreateUserId)
                    .HasConstraintName("FK_ClassArticle_User");
            });

            modelBuilder.Entity<ClassArticleCollection>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ClassArticleCollection)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_ClassArticleCollection_ClassArticle");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClassArticleCollection)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ClassArticleCollection_User");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentCategoryId).HasColumnName("CommentCategoryID");

                entity.Property(e => e.CommentContent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTargetId).HasColumnName("CommentTargetID");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CommentUserId).HasColumnName("CommentUserID");

                entity.HasOne(d => d.CommentCategory)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.CommentCategoryId)
                    .HasConstraintName("FK_Comment_CommentCategory");

                entity.HasOne(d => d.CommentUser)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.CommentUserId)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<CommentCategory>(entity =>
            {
                entity.Property(e => e.CommentCategoryId).HasColumnName("CommentCategoryID");

                entity.Property(e => e.CommentTargetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Commodity>(entity =>
            {
                entity.Property(e => e.CommodityId).HasColumnName("Commodity_Id");

                entity.Property(e => e.AnimalCategoryId).HasColumnName("AnimalCategoryID");

                entity.Property(e => e.AnimalFengLeiId).HasColumnName("AnimalFengLei_ID");

                entity.Property(e => e.CommodityContent)
                    .HasColumnName("Commodity_Content")
                    .IsUnicode(false);

                entity.Property(e => e.CommodityName)
                    .IsRequired()
                    .HasColumnName("Commodity_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.CommodityP1)
                    .IsRequired()
                    .HasColumnName("Commodity_P1");

                entity.Property(e => e.CommodityP2).HasColumnName("Commodity_P2");

                entity.Property(e => e.CommodityP3).HasColumnName("Commodity_P3");

                entity.Property(e => e.CommodityP4).HasColumnName("Commodity_P4");

                entity.Property(e => e.CommodityPrice)
                    .HasColumnName("Commodity_Price")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CommodityS1).HasColumnName("Commodity_S1");

                entity.Property(e => e.CommodityS2).HasColumnName("Commodity_S2");

                entity.Property(e => e.CommodityS3).HasColumnName("Commodity_S3");

                entity.Property(e => e.CommoditySummary)
                    .IsRequired()
                    .HasColumnName("Commodity_Summary")
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<DeliveryAddress>(entity =>
            {
                entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddress_Id");

                entity.Property(e => e.DeliveryAddressAddress).HasColumnName("DeliveryAddress_Address");

                entity.Property(e => e.DeliveryAddressName)
                    .HasColumnName("DeliveryAddress_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryAddressNumber)
                    .IsRequired()
                    .HasColumnName("DeliveryAddress_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryAddressRegion)
                    .HasColumnName("DeliveryAddress_Region")
                    .HasMaxLength(10);

                entity.Property(e => e.DeliveryAddressZipcode)
                    .HasColumnName("DeliveryAddress_Zipcode")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<EnCategory>(entity =>
            {
                entity.HasKey(e => e.EnId);

                entity.Property(e => e.EnId).HasColumnName("EnID");

                entity.Property(e => e.EnName)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FindLostPet>(entity =>
            {
                entity.HasKey(e => e.FindLostId);

                entity.Property(e => e.FindLostId).HasColumnName("FindLostID");

                entity.Property(e => e.Fcontent)
                    .HasColumnName("FContent")
                    .IsUnicode(false);

                entity.Property(e => e.ForLostId).HasColumnName("For_LostID");

                entity.Property(e => e.Fphone)
                    .HasColumnName("FPhone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FuserId).HasColumnName("FUserID");
            });

            modelBuilder.Entity<FindPickPet>(entity =>
            {
                entity.HasKey(e => e.FindPickId);

                entity.Property(e => e.FindPickId).HasColumnName("FindPickID");

                entity.Property(e => e.Fcontent)
                    .HasColumnName("FContent")
                    .IsUnicode(false);

                entity.Property(e => e.ForPickId).HasColumnName("For_PickID");

                entity.Property(e => e.Fphone)
                    .HasColumnName("FPhone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FuserId).HasColumnName("FUserID");
            });

            modelBuilder.Entity<FwshopComment>(entity =>
            {
                entity.ToTable("FWShopComment");

                entity.Property(e => e.FwshopCommentId).HasColumnName("FWShopCommentID");

                entity.Property(e => e.CommentContent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommentUserId).HasColumnName("CommentUserID");

                entity.Property(e => e.ForPackageId).HasColumnName("For_PackageID");

                entity.Property(e => e.ForServiceProjectId).HasColumnName("For_ServiceProjectID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.HasOne(d => d.CommentUser)
                    .WithMany(p => p.FwshopComment)
                    .HasForeignKey(d => d.CommentUserId)
                    .HasConstraintName("FK_FWShopComment_User");

                entity.HasOne(d => d.ForPackage)
                    .WithMany(p => p.FwshopComment)
                    .HasForeignKey(d => d.ForPackageId)
                    .HasConstraintName("FK_FWShopComment_ProjectPackage");

                entity.HasOne(d => d.ForServiceProject)
                    .WithMany(p => p.FwshopComment)
                    .HasForeignKey(d => d.ForServiceProjectId)
                    .HasConstraintName("FK_FWShopComment_ShopServiceProject");

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.FwshopComment)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_FWShopComment_PetServiceShop");
            });

            modelBuilder.Entity<GetPet>(entity =>
            {
                entity.HasKey(e => e.GetId);

                entity.Property(e => e.GetId).HasColumnName("GetID");

                entity.Property(e => e.Feature)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.GetContent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GetPic).IsUnicode(false);

                entity.Property(e => e.GetUserId).HasColumnName("GetUserID");

                entity.Property(e => e.Gname)
                    .HasColumnName("GName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gphone)
                    .HasColumnName("GPhone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.HairColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PetCategoryId).HasColumnName("PetCategoryID");

                entity.Property(e => e.PetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PubArea).IsUnicode(false);

                entity.Property(e => e.PubTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PutUserId).HasColumnName("PutUserID");

                entity.HasOne(d => d.GetUser)
                    .WithMany(p => p.GetPet)
                    .HasForeignKey(d => d.GetUserId)
                    .HasConstraintName("FK_GetPet_User");

                entity.HasOne(d => d.PetCategory)
                    .WithMany(p => p.GetPet)
                    .HasForeignKey(d => d.PetCategoryId)
                    .HasConstraintName("FK_GetPet_PetCategory");
            });

            modelBuilder.Entity<LostPet>(entity =>
            {
                entity.HasKey(e => e.LostId);

                entity.Property(e => e.LostId).HasColumnName("LostID");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.HairColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ldescription)
                    .HasColumnName("LDescription")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LostContent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LostPic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LostTime).HasColumnType("datetime");

                entity.Property(e => e.LostUserId).HasColumnName("LostUserID");

                entity.Property(e => e.Lphone)
                    .HasColumnName("LPhone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PetCategoryId).HasColumnName("PetCategoryID");

                entity.Property(e => e.PetName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PubArea).IsUnicode(false);

                entity.Property(e => e.PubTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PutUserId).HasColumnName("PutUserID");

                entity.HasOne(d => d.LostUser)
                    .WithMany(p => p.LostPet)
                    .HasForeignKey(d => d.LostUserId)
                    .HasConstraintName("FK_LostPet_User");

                entity.HasOne(d => d.PetCategory)
                    .WithMany(p => p.LostPet)
                    .HasForeignKey(d => d.PetCategoryId)
                    .HasConstraintName("FK_LostPet_PetCategory");
            });

            modelBuilder.Entity<LoveShowPhotos>(entity =>
            {
                entity.HasKey(e => e.LoveShowPhotoId);

                entity.Property(e => e.LoveShowPhotoId).HasColumnName("LoveShowPhotoID");

                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.BrowseNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiveZanNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.Image1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LspCategoryId).HasColumnName("LspCategoryID");

                entity.Property(e => e.LspContent).IsUnicode(false);

                entity.Property(e => e.LspCreateUserId).HasColumnName("LspCreateUserID");

                entity.Property(e => e.LspTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoList)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArticleCategory)
                    .WithMany(p => p.LoveShowPhotos)
                    .HasForeignKey(d => d.ArticleCategoryId)
                    .HasConstraintName("FK_LoveShowPhotos_User");
            });

            modelBuilder.Entity<LoveShowVideos>(entity =>
            {
                entity.HasKey(e => e.LoveShowVideoId);

                entity.Property(e => e.LoveShowVideoId).HasColumnName("LoveShowVideoID");

                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GiveZanNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.LsvBrowseNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.LsvCategoryId).HasColumnName("LsvCategoryID");

                entity.Property(e => e.LsvCotent).IsUnicode(false);

                entity.Property(e => e.LsvReleaseUserId).HasColumnName("LsvReleaseUserID");

                entity.Property(e => e.LsvTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LsvVideo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArticleCategory)
                    .WithMany(p => p.LoveShowVideos)
                    .HasForeignKey(d => d.ArticleCategoryId)
                    .HasConstraintName("FK_LoveShowVideos_User");
            });

            modelBuilder.Entity<LuoKiShop>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.FitPet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForPetCategory).HasColumnName("For_PetCategory");

                entity.Property(e => e.ForShopCategory).HasColumnName("For_ShopCategory");

                entity.Property(e => e.MainComponent)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SaleSum).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShopBigIntro).IsUnicode(false);

                entity.Property(e => e.ShopBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopGuiGe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImg1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImg2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImg3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImg4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImg5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopIntroduce)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoSrc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("MArea");

                entity.Property(e => e.AreaId).ValueGeneratedNever();

                entity.Property(e => e.AreaEn)
                    .HasColumnName("AreaEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ForCityId).HasColumnName("ForCityID");
            });

            modelBuilder.Entity<Mcity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("MCity");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityEn)
                    .HasColumnName("CityEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemPet>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemAffair)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MemAgent)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemGroup)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.MemName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MemPhoto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemPic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemUserId).HasColumnName("MemUserID");

                entity.HasOne(d => d.MemUser)
                    .WithMany(p => p.MemPet)
                    .HasForeignKey(d => d.MemUserId)
                    .HasConstraintName("FK_MemPet_User");
            });

            modelBuilder.Entity<Mnode>(entity =>
            {
                entity.HasKey(e => e.NodeId);

                entity.ToTable("MNode");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.FirstEn)
                    .HasColumnName("FirstEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ForAreaId).HasColumnName("ForAreaID");

                entity.Property(e => e.ForCityId).HasColumnName("ForCityID");

                entity.Property(e => e.NodeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MpetServiceShop>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.ToTable("MPetServiceShop");

                entity.Property(e => e.ShopId)
                    .HasColumnName("Shop_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessHours)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Car)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ForAreaId).HasColumnName("ForAreaID");

                entity.Property(e => e.ForCityId).HasColumnName("ForCityID");

                entity.Property(e => e.ForNodeId).HasColumnName("ForNodeID");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.Node)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImg).IsUnicode(false);

                entity.Property(e => e.ShopIntroduce)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WiFi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MpetServiceShopOrder>(entity =>
            {
                entity.HasKey(e => e.MshopServiceOrderId);

                entity.ToTable("MPetServiceShopOrder");

                entity.Property(e => e.MshopServiceOrderId).HasColumnName("MShopServiceOrderID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderUseState).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderUserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderVoucheCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MservicePackage>(entity =>
            {
                entity.HasKey(e => e.PackageId);

                entity.ToTable("MServicePackage");

                entity.Property(e => e.PackageId).ValueGeneratedNever();

                entity.Property(e => e.ForServiceId).HasColumnName("ForServiceID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sprice).HasColumnName("sprice");
            });

            modelBuilder.Entity<MserviceShopOrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId);

                entity.ToTable("MServiceShopOrderDetails");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.DetailsUserState).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForOrderId).HasColumnName("ForOrderID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PackageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MshopService>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("MShopService");

                entity.Property(e => e.ServiceId).ValueGeneratedNever();

                entity.Property(e => e.ForServiceCateId).HasColumnName("ForServiceCateID");

                entity.Property(e => e.ForServiceCateName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ForShopId).HasColumnName("ForShopID");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MshopServiceCate>(entity =>
            {
                entity.HasKey(e => e.CateId);

                entity.ToTable("MShopServiceCate");

                entity.Property(e => e.CateId).ValueGeneratedNever();

                entity.Property(e => e.CateName).HasMaxLength(10);
            });

            modelBuilder.Entity<PetActive>(entity =>
            {
                entity.Property(e => e.PetActiveId).HasColumnName("PetActiveID");

                entity.Property(e => e.ActiveTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.PetActiveTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PetCategory>(entity =>
            {
                entity.Property(e => e.PetCategoryId).HasColumnName("PetCategoryID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AniMalCategoryId).HasColumnName("AniMalCategoryID");

                entity.Property(e => e.AppearanceLevel).HasColumnName("Appearance_Level");

                entity.Property(e => e.BaseInfo).HasColumnName("Base_Info");

                entity.Property(e => e.CallLevel).HasColumnName("Call_Level");

                entity.Property(e => e.CanTrainLevel).HasColumnName("CanTrain_Level");

                entity.Property(e => e.CareNeeds).HasColumnName("Care_needs");

                entity.Property(e => e.ColdResistance).HasColumnName("Cold_resistance");

                entity.Property(e => e.EnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExerciseLevel).HasColumnName("Exercise_Level");

                entity.Property(e => e.FeedDifficulty).HasColumnName("Feed_difficulty");

                entity.Property(e => e.FriendlyLevel).HasColumnName("Friendly_Level");

                entity.Property(e => e.Function)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GluttonousLevel).HasColumnName("Gluttonous_Level");

                entity.Property(e => e.GuJiaLevel).HasColumnName("GuJia_Level");

                entity.Property(e => e.Hair)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HairColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HairfallingLevel).HasColumnName("Hairfalling_Level");

                entity.Property(e => e.HeatResistance).HasColumnName("Heat_resistance");

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Intelligence)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NeedCare).HasColumnName("Need_Care");

                entity.Property(e => e.NursKnowledge).HasColumnName("Nurs_knowledge");

                entity.Property(e => e.Origin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PetCategoryIntroduce)
                    .IsRequired()
                    .HasColumnName("PetCategory_Introduce")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PetCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PetCategoryPhotos)
                    .IsRequired()
                    .HasColumnName("PetCategory_Photos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shape)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StickyLevel).HasColumnName("Sticky_Level");

                entity.Property(e => e.TasteLevel).HasColumnName("Taste_Level");

                entity.Property(e => e.VarietyCharact).HasColumnName("Variety_charact");

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AniMalCategory)
                    .WithMany(p => p.PetCategory)
                    .HasForeignKey(d => d.AniMalCategoryId)
                    .HasConstraintName("FK_PetCategory_AnimalCategory");
            });

            modelBuilder.Entity<PetDisease>(entity =>
            {
                entity.HasKey(e => e.DiseaseId);

                entity.Property(e => e.DiseaseId).HasColumnName("DiseaseID");

                entity.Property(e => e.DiseaseCause)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DiseaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForEn)
                    .HasColumnName("For-EN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ForPetCaegoryId).HasColumnName("For-PetCaegoryID");

                entity.Property(e => e.ForSymptomId).HasColumnName("For_SymptomID");

                entity.Property(e => e.Genera)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MainSymptom).IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Symptom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Treatment).IsUnicode(false);

                entity.Property(e => e.Zdbz)
                    .HasColumnName("ZDBZ")
                    .IsUnicode(false);

                entity.HasOne(d => d.ForSymptom)
                    .WithMany(p => p.PetDisease)
                    .HasForeignKey(d => d.ForSymptomId)
                    .HasConstraintName("FK_PetDisease_PetPositionSymptom");
            });

            modelBuilder.Entity<PetInformation>(entity =>
            {
                entity.Property(e => e.PetInformationId).HasColumnName("PetInformationID");

                entity.Property(e => e.BrowserNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.InfoCategoryId).HasColumnName("InfoCategoryID");

                entity.Property(e => e.Introduce)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsHot).HasDefaultValueSql("((0))");

                entity.Property(e => e.Photo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PublishTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateUser)
                    .WithMany(p => p.PetInformation)
                    .HasForeignKey(d => d.CreateUserId)
                    .HasConstraintName("FK_PetInformation_User");
            });

            modelBuilder.Entity<PetInformationCollection>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.PetInformationCollection)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_PetInformationCollection_PetInformation");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PetInformationCollection)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PetInformationCollection_User");
            });

            modelBuilder.Entity<PetPosition>(entity =>
            {
                entity.Property(e => e.PetPositionId).HasColumnName("PetPositionID");

                entity.Property(e => e.ForPetCategoryId).HasColumnName("For_PetCategoryID");

                entity.Property(e => e.PetPositionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PetPositionSymptom>(entity =>
            {
                entity.Property(e => e.PetPositionSymptomId).HasColumnName("PetPositionSymptomID");

                entity.Property(e => e.Describe)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ForPetPositionId).HasColumnName("For_PetPositionID");

                entity.Property(e => e.SymptomName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ForPetPosition)
                    .WithMany(p => p.PetPositionSymptom)
                    .HasForeignKey(d => d.ForPetPositionId)
                    .HasConstraintName("FK_PetPositionSymptom_PetPosition");
            });

            modelBuilder.Entity<PetProblem>(entity =>
            {
                entity.Property(e => e.PetProblemId).HasColumnName("PetProblemID");

                entity.Property(e => e.BrowserNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.PublishTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PetRl>(entity =>
            {
                entity.Property(e => e.PetRlId).HasColumnName("PetRlID");

                entity.Property(e => e.ForGetId).HasColumnName("For_GetID");

                entity.Property(e => e.Pcontent)
                    .HasColumnName("PContent")
                    .IsUnicode(false);

                entity.Property(e => e.Pisid).HasColumnName("PISID");

                entity.Property(e => e.Pislook).HasColumnName("PISLook");

                entity.Property(e => e.Pissterilisation).HasColumnName("PISSterilisation");

                entity.Property(e => e.Pname)
                    .HasColumnName("PName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pphone)
                    .HasColumnName("PPhone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Presidence)
                    .HasColumnName("PResidence")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Psalary)
                    .HasColumnName("PSalary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psex).HasColumnName("PSex");

                entity.Property(e => e.Ptitle)
                    .HasColumnName("PTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RlUserId).HasColumnName("RlUserID");

                entity.HasOne(d => d.RlUser)
                    .WithMany(p => p.PetRl)
                    .HasForeignKey(d => d.RlUserId)
                    .HasConstraintName("FK_PetRl_User");
            });

            modelBuilder.Entity<PetServiceCartDetails>(entity =>
            {
                entity.HasKey(e => e.PetServiceCartDetailId);

                entity.Property(e => e.PetServiceCartDetailId).HasColumnName("PetServiceCartDetailID");

                entity.Property(e => e.Detailed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForPetServiceCartId).HasColumnName("For_PetServiceCartID");

                entity.Property(e => e.ForProjectPackageId).HasColumnName("For_ProjectPackageID");

                entity.Property(e => e.ForServiceProjectId).HasColumnName("For_ServiceProjectID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.ForUserId).HasColumnName("For_UserID");

                entity.HasOne(d => d.ForPetServiceCart)
                    .WithMany(p => p.PetServiceCartDetails)
                    .HasForeignKey(d => d.ForPetServiceCartId)
                    .HasConstraintName("FK_PetServiceCartDetails_PetServiceCartDetails");

                entity.HasOne(d => d.ForProjectPackage)
                    .WithMany(p => p.PetServiceCartDetails)
                    .HasForeignKey(d => d.ForProjectPackageId)
                    .HasConstraintName("FK_PetServiceCart_ProjectPackage");

                entity.HasOne(d => d.ForServiceProject)
                    .WithMany(p => p.PetServiceCartDetails)
                    .HasForeignKey(d => d.ForServiceProjectId)
                    .HasConstraintName("FK_PetServiceCart_ShopServiceProject");

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.PetServiceCartDetails)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_PetServiceCart_PetServiceShop1");

                entity.HasOne(d => d.ForUser)
                    .WithMany(p => p.PetServiceCartDetails)
                    .HasForeignKey(d => d.ForUserId)
                    .HasConstraintName("FK_PetServiceCart_User");
            });

            modelBuilder.Entity<PetServiceCarts>(entity =>
            {
                entity.HasKey(e => e.PetServiceCartId);

                entity.Property(e => e.PetServiceCartId).HasColumnName("PetServiceCartID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.ForUserId).HasColumnName("For_UserID");

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.PetServiceCarts)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_PetServiceCarts_PetServiceShop");

                entity.HasOne(d => d.ForUser)
                    .WithMany(p => p.PetServiceCarts)
                    .HasForeignKey(d => d.ForUserId)
                    .HasConstraintName("FK_PetServiceCarts_User");
            });

            modelBuilder.Entity<PetServiceOrder>(entity =>
            {
                entity.Property(e => e.PetServiceOrderId).HasColumnName("PetServiceOrderID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.ForUserId).HasColumnName("For_UserID");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.PetServiceOrder)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_PetServiceOrder_PetServiceShop");

                entity.HasOne(d => d.ForUser)
                    .WithMany(p => p.PetServiceOrder)
                    .HasForeignKey(d => d.ForUserId)
                    .HasConstraintName("FK_PetServiceOrder_User");
            });

            modelBuilder.Entity<PetServiceOrderDetails>(entity =>
            {
                entity.HasKey(e => e.PetServiceOrderDetailId);

                entity.Property(e => e.PetServiceOrderDetailId).HasColumnName("PetServiceOrderDetailID");

                entity.Property(e => e.Detailed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForPetServiceOrderId).HasColumnName("For_PetServiceOrderID");

                entity.Property(e => e.ForProjectPackageId).HasColumnName("For_ProjectPackageID");

                entity.Property(e => e.ForServiceProjectId).HasColumnName("For_ServiceProjectID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.ForUserId).HasColumnName("For_UserID");

                entity.HasOne(d => d.ForProjectPackage)
                    .WithMany(p => p.PetServiceOrderDetails)
                    .HasForeignKey(d => d.ForProjectPackageId)
                    .HasConstraintName("FK_PetServiceOrderDetails_ProjectPackage");

                entity.HasOne(d => d.ForServiceProject)
                    .WithMany(p => p.PetServiceOrderDetails)
                    .HasForeignKey(d => d.ForServiceProjectId)
                    .HasConstraintName("FK_PetServiceOrderDetails_ShopServiceProject");

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.PetServiceOrderDetails)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_PetServiceOrderDetails_PetServiceShop");

                entity.HasOne(d => d.ForUser)
                    .WithMany(p => p.PetServiceOrderDetails)
                    .HasForeignKey(d => d.ForUserId)
                    .HasConstraintName("FK_PetServiceOrderDetails_User");
            });

            modelBuilder.Entity<PetServiceShop>(entity =>
            {
                entity.Property(e => e.PetServiceShopId).HasColumnName("PetServiceShopID");

                entity.Property(e => e.AddressJwd)
                    .HasColumnName("AddressJWD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessHours)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ForAreaId).HasColumnName("For_AreaID");

                entity.Property(e => e.ForCityId).HasColumnName("For_CityID");

                entity.Property(e => e.ForUserId).HasColumnName("For_UserID");

                entity.Property(e => e.HasBath).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasDesigner).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasFoster).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasMedicalCare)
                    .HasColumnName("HasMedical-Care")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PetServiceShopName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImage1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImage2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImage3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImage4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImage5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopImage6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ForArea)
                    .WithMany(p => p.PetServiceShop)
                    .HasForeignKey(d => d.ForAreaId)
                    .HasConstraintName("FK_PetServiceShop_Area");

                entity.HasOne(d => d.ForCity)
                    .WithMany(p => p.PetServiceShop)
                    .HasForeignKey(d => d.ForCityId)
                    .HasConstraintName("FK_PetServiceShop_City");
            });

            modelBuilder.Entity<PickPet>(entity =>
            {
                entity.HasKey(e => e.PickId);

                entity.Property(e => e.PickId).HasColumnName("PickID");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.HairColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PetCategoryId).HasColumnName("PetCategoryID");

                entity.Property(e => e.PickContent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickPic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUserId).HasColumnName("PickUserID");

                entity.Property(e => e.Pidescription)
                    .HasColumnName("PIDescription")
                    .IsUnicode(false);

                entity.Property(e => e.Piname)
                    .HasColumnName("PIName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Piphone)
                    .HasColumnName("PIPhone")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Pitime)
                    .HasColumnName("PITime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PubArea).IsUnicode(false);

                entity.Property(e => e.PubTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PutUserId).HasColumnName("PutUserID");

                entity.HasOne(d => d.PetCategory)
                    .WithMany(p => p.PickPet)
                    .HasForeignKey(d => d.PetCategoryId)
                    .HasConstraintName("FK_PickPet_PetCategory");

                entity.HasOne(d => d.PickUser)
                    .WithMany(p => p.PickPet)
                    .HasForeignKey(d => d.PickUserId)
                    .HasConstraintName("FK_PickPet_User");
            });

            modelBuilder.Entity<ProjectPackage>(entity =>
            {
                entity.Property(e => e.ProjectPackageId).HasColumnName("ProjectPackageID");

                entity.Property(e => e.ForProjectId).HasColumnName("For_ProjectID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.PackgelName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ForProject)
                    .WithMany(p => p.ProjectPackage)
                    .HasForeignKey(d => d.ForProjectId)
                    .HasConstraintName("FK_ProjectPackage_ShopServiceProject");
            });

            modelBuilder.Entity<ReceivingAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Consignee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetailedNode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Reply>(entity =>
            {
                entity.Property(e => e.ReplyId).HasColumnName("ReplyID");

                entity.Property(e => e.ReplayTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReplyCommentId).HasColumnName("Reply_CommentID");

                entity.Property(e => e.ReplyContent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyTargetId).HasColumnName("ReplyTargetID");

                entity.Property(e => e.ReplyUserId).HasColumnName("ReplyUserID");

                entity.HasOne(d => d.ReplyComment)
                    .WithMany(p => p.Reply)
                    .HasForeignKey(d => d.ReplyCommentId)
                    .HasConstraintName("FK_Reply_Comment");

                entity.HasOne(d => d.ReplyTarget)
                    .WithMany(p => p.ReplyReplyTarget)
                    .HasForeignKey(d => d.ReplyTargetId)
                    .HasConstraintName("FK_Reply_User");

                entity.HasOne(d => d.ReplyUser)
                    .WithMany(p => p.ReplyReplyUser)
                    .HasForeignKey(d => d.ReplyUserId)
                    .HasConstraintName("FK_Reply_User1");
            });

            modelBuilder.Entity<ServiceCaegory>(entity =>
            {
                entity.HasKey(e => e.ServiceCategoryId);

                entity.Property(e => e.ServiceCategoryId).HasColumnName("Service_CategoryID");

                entity.Property(e => e.ServiceCategoryName)
                    .HasColumnName("Service_CategoryName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceShopCollection>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ServiceShopCollection)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_ServiceShopCollection_PetServiceShop");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceShopCollection)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ServiceShopCollection_User");
            });

            modelBuilder.Entity<ShopCart>(entity =>
            {
                entity.Property(e => e.ShopCartId).HasColumnName("ShopCartID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.ForUserId).HasColumnName("For_UserID");

                entity.Property(e => e.ShopImage)
                    .HasColumnName("Shop_Image")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShopNmae)
                    .HasColumnName("Shop_Nmae")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopPrice).HasColumnName("Shop_Price");
            });

            modelBuilder.Entity<ShopServiceProject>(entity =>
            {
                entity.HasKey(e => e.ShopServicesItemId);

                entity.Property(e => e.ShopServicesItemId).HasColumnName("ShopServicesItemID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.SaleNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("ServiceCategoryID");

                entity.Property(e => e.ServiceItemName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.ShopServiceProject)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_ShopServiceProject_PetServiceShop");

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.ShopServiceProject)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .HasConstraintName("FK_ShopServiceProject_ServiceCaegory");
            });

            modelBuilder.Entity<ShopType>(entity =>
            {
                entity.Property(e => e.ShopTypeId).HasColumnName("ShopTypeID");

                entity.Property(e => e.ForShopId).HasColumnName("For_ShopID");

                entity.Property(e => e.MarkPrice).HasColumnName("Mark_Price");

                entity.Property(e => e.ShopPrice).HasColumnName("Shop_Price");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ForShop)
                    .WithMany(p => p.ShopType)
                    .HasForeignKey(d => d.ForShopId)
                    .HasConstraintName("FK_ShopType_LuoKiShop");
            });

            modelBuilder.Entity<SupportWork>(entity =>
            {
                entity.Property(e => e.SupportWorkId).HasColumnName("SupportWorkID");

                entity.Property(e => e.ForWorkId).HasColumnName("For_WorkID");

                entity.Property(e => e.SupportUserId).HasColumnName("SupportUserID");

                entity.HasOne(d => d.ForWork)
                    .WithMany(p => p.SupportWork)
                    .HasForeignKey(d => d.ForWorkId)
                    .HasConstraintName("FK_SupportWork_ActiveWork");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Expertise)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ForAreaId).HasColumnName("For_AreaID");

                entity.Property(e => e.ForCityId).HasColumnName("For_CityID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QqaccessToken)
                    .HasColumnName("QQAccess_Token")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QqopenId)
                    .HasColumnName("QQOpenId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rpassword)
                    .HasColumnName("RPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('check Sex in(''男'',''女'')')");

                entity.Property(e => e.UserBoQiMoney)
                    .HasColumnName("User_BoQiMoney")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserIntroduce)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhotos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ForArea)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ForAreaId)
                    .HasConstraintName("FK_User_Area");

                entity.HasOne(d => d.ForCity)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ForCityId)
                    .HasConstraintName("FK_User_City");
            });

            modelBuilder.Entity<UserFriendly>(entity =>
            {
                entity.HasKey(e => e.FriendlyId);

                entity.Property(e => e.FriendlyId).HasColumnName("FriendlyID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });
            modelBuilder.Entity<ManageMenu>(entity =>
            {
                entity.HasKey(e => e.ManageMenuID);
                entity.Property(e => e.MenuName).HasColumnName("MenuName");
                entity.Property(e => e.MenuIcon).HasColumnName("MenuIcon");
                entity.Property(e => e.DataName).HasColumnName("DataName");
            });
            modelBuilder.Entity<ManagerMenuChild>(entity =>
            {
                entity.HasKey(e => e.ManagerMenuChildID);
                entity.Property(e => e.MenuChildName).HasColumnName("MenuChildName");
                entity.Property(e => e.MenuChildHref).HasColumnName("MenuChildHref");
                entity.Property(e => e.ForMenuID).HasColumnName("ForMenuID");
                entity.Property(e => e.DataName).HasColumnName("DataName");
            });
        }
    }
}
