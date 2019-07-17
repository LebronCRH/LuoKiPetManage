using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class LuoKiPet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorsID);
                });

            migrationBuilder.CreateTable(
                name: "AnimalCategory",
                columns: table => new
                {
                    AnimalCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimalCategoryName = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalCategory", x => x.AnimalCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "AnimalFengLei",
                columns: table => new
                {
                    AnimalFengLei_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimalCategoryID = table.Column<int>(nullable: false),
                    AnimalFengLei = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalFengLei", x => x.AnimalFengLei_ID);
                });

            migrationBuilder.CreateTable(
                name: "AppPetArticle",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false),
                    ArticleTitle = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ArticleSubtitle = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ArticleCove = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ArticleContent = table.Column<string>(unicode: false, nullable: true),
                    ArticleCreateUserID = table.Column<int>(nullable: true),
                    ArticleCategoryID = table.Column<int>(nullable: true),
                    ArticlePublish = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPetArticle", x => x.ArticleID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    ArticleCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleNmae = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => x.ArticleCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleOperation",
                columns: table => new
                {
                    ArticleOperationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: true),
                    ArticleID = table.Column<int>(nullable: true),
                    ArticleCategoryID = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleOperation", x => x.ArticleOperationID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "CommentCategory",
                columns: table => new
                {
                    CommentCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentTargetName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentCategory", x => x.CommentCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    Commodity_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnimalCategoryID = table.Column<int>(nullable: false),
                    Commodity_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Commodity_Price = table.Column<decimal>(type: "numeric(10, 2)", nullable: false),
                    Commodity_Summary = table.Column<string>(maxLength: 160, nullable: false),
                    Commodity_P1 = table.Column<string>(nullable: false),
                    Commodity_P2 = table.Column<string>(nullable: true),
                    Commodity_P3 = table.Column<string>(nullable: true),
                    Commodity_P4 = table.Column<string>(nullable: true),
                    Commodity_S1 = table.Column<string>(nullable: true),
                    Commodity_S2 = table.Column<string>(nullable: true),
                    Commodity_S3 = table.Column<string>(nullable: true),
                    AnimalFengLei_ID = table.Column<int>(nullable: true),
                    Commodity_Content = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Commodity_Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryAddress",
                columns: table => new
                {
                    DeliveryAddress_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryAddress_Name = table.Column<string>(maxLength: 10, nullable: true),
                    DeliveryAddress_Number = table.Column<string>(maxLength: 50, nullable: false),
                    DeliveryAddress_Zipcode = table.Column<string>(maxLength: 10, nullable: true),
                    DeliveryAddress_Region = table.Column<string>(maxLength: 10, nullable: true),
                    DeliveryAddress_Address = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryAddress", x => x.DeliveryAddress_Id);
                });

            migrationBuilder.CreateTable(
                name: "EnCategory",
                columns: table => new
                {
                    EnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnName = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnCategory", x => x.EnID);
                });

            migrationBuilder.CreateTable(
                name: "FindLostPet",
                columns: table => new
                {
                    FindLostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    FContent = table.Column<string>(unicode: false, nullable: true),
                    FUserID = table.Column<int>(nullable: true),
                    For_LostID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FindLostPet", x => x.FindLostID);
                });

            migrationBuilder.CreateTable(
                name: "FindPickPet",
                columns: table => new
                {
                    FindPickID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    FContent = table.Column<string>(unicode: false, nullable: true),
                    FUserID = table.Column<int>(nullable: true),
                    For_PickID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FindPickPet", x => x.FindPickID);
                });

            migrationBuilder.CreateTable(
                name: "LuoKiShop",
                columns: table => new
                {
                    ShopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShopName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopPrice = table.Column<double>(nullable: true),
                    MarketPrice = table.Column<double>(nullable: true),
                    ShopBrand = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ShopIntroduce = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ShopGuiGe = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MainComponent = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    FitPet = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    VideoSrc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ShopImg1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImg2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImg3 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImg4 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImg5 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImg6 = table.Column<byte[]>(nullable: true),
                    ShopBigIntro = table.Column<string>(unicode: false, nullable: true),
                    For_PetCategory = table.Column<int>(nullable: true),
                    For_ShopCategory = table.Column<int>(nullable: true),
                    SaleSum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    ShopUrl = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuoKiShop", x => x.ShopID);
                });

            migrationBuilder.CreateTable(
                name: "MArea",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ForCityID = table.Column<int>(nullable: true),
                    AreaEN = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MArea", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "MCity",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CityEN = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCity", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "MNode",
                columns: table => new
                {
                    NodeId = table.Column<int>(nullable: false),
                    NodeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ForAreaID = table.Column<int>(nullable: true),
                    FirstEN = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    ForCityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MNode", x => x.NodeId);
                });

            migrationBuilder.CreateTable(
                name: "MPetServiceShop",
                columns: table => new
                {
                    Shop_id = table.Column<int>(nullable: false),
                    ShopName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImg = table.Column<string>(unicode: false, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Node = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    BusinessHours = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Car = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    WiFi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MinPrice = table.Column<double>(nullable: true),
                    SaleNum = table.Column<int>(nullable: true),
                    ShopIntroduce = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    lng = table.Column<double>(nullable: false),
                    lat = table.Column<double>(nullable: false),
                    Evaluate = table.Column<double>(nullable: true),
                    Distance = table.Column<double>(nullable: true),
                    ForCityID = table.Column<int>(nullable: true),
                    ForAreaID = table.Column<int>(nullable: true),
                    ForNodeID = table.Column<int>(nullable: true),
                    ShopPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPetServiceShop", x => x.Shop_id);
                });

            migrationBuilder.CreateTable(
                name: "MPetServiceShopOrder",
                columns: table => new
                {
                    MShopServiceOrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<int>(nullable: true),
                    ShopName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    OrderTolatPrice = table.Column<double>(nullable: true),
                    YouHuiQuan = table.Column<double>(nullable: true),
                    BoQiBean = table.Column<double>(nullable: true),
                    ActualPrice = table.Column<double>(nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OrderState = table.Column<int>(nullable: true),
                    CreateUserID = table.Column<int>(nullable: true),
                    OrderServiceNum = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    OrderUserPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OrderVoucheCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    OrderUseState = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPetServiceShopOrder", x => x.MShopServiceOrderID);
                });

            migrationBuilder.CreateTable(
                name: "MServicePackage",
                columns: table => new
                {
                    PackageId = table.Column<int>(nullable: false),
                    name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Oldprice = table.Column<double>(nullable: true),
                    sprice = table.Column<double>(nullable: true),
                    ForServiceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MServicePackage", x => x.PackageId);
                });

            migrationBuilder.CreateTable(
                name: "MServiceShopOrderDetails",
                columns: table => new
                {
                    OrderDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceID = table.Column<int>(nullable: true),
                    ServiceName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PackageID = table.Column<int>(nullable: true),
                    PackageName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ServiceNum = table.Column<int>(nullable: true),
                    OnePrice = table.Column<double>(nullable: true),
                    ForOrderID = table.Column<int>(nullable: true),
                    DetailsUserState = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MServiceShopOrderDetails", x => x.OrderDetailsID);
                });

            migrationBuilder.CreateTable(
                name: "MShopService",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false),
                    ServiceName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    SaleNum = table.Column<int>(nullable: true),
                    OldPrice = table.Column<double>(nullable: true),
                    MinPrice = table.Column<double>(nullable: true),
                    ForServiceCateID = table.Column<int>(nullable: true),
                    ForServiceCateName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ForShopID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MShopService", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "MShopServiceCate",
                columns: table => new
                {
                    CateId = table.Column<int>(nullable: false),
                    CateName = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MShopServiceCate", x => x.CateId);
                });

            migrationBuilder.CreateTable(
                name: "PetActive",
                columns: table => new
                {
                    PetActiveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Content = table.Column<string>(unicode: false, nullable: true),
                    PetActiveTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ActiveTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetActive", x => x.PetActiveID);
                });

            migrationBuilder.CreateTable(
                name: "PetPosition",
                columns: table => new
                {
                    PetPositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PetPositionName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    For_PetCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetPosition", x => x.PetPositionID);
                });

            migrationBuilder.CreateTable(
                name: "PetProblem",
                columns: table => new
                {
                    PetProblemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreateUserID = table.Column<int>(nullable: true),
                    IsManage = table.Column<int>(nullable: true),
                    Content = table.Column<string>(unicode: false, nullable: true),
                    CategoryID = table.Column<int>(nullable: true),
                    BrowserNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    IsHot = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetProblem", x => x.PetProblemID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: true),
                    Consignee = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ContactPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Area = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DetailedNode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDefault = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingAddress", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCaegory",
                columns: table => new
                {
                    Service_CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Service_CategoryName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCaegory", x => x.Service_CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ShopCart",
                columns: table => new
                {
                    ShopCartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_UserID = table.Column<int>(nullable: true),
                    For_ShopID = table.Column<int>(nullable: true),
                    Shop_Nmae = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Shop_Price = table.Column<double>(nullable: true),
                    Amount = table.Column<int>(nullable: true),
                    Shop_Image = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCart", x => x.ShopCartID);
                });

            migrationBuilder.CreateTable(
                name: "UserFriendly",
                columns: table => new
                {
                    FriendlyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ToUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriendly", x => x.FriendlyID);
                });

            migrationBuilder.CreateTable(
                name: "PetCategory",
                columns: table => new
                {
                    PetCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PetCategoryName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Alias = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Shape = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Hair = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    EnName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Intelligence = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Origin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Weight = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Price = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Height = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HairColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Function = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Taste_Level = table.Column<int>(nullable: true),
                    Exercise_Level = table.Column<int>(nullable: true),
                    Heat_resistance = table.Column<int>(nullable: true),
                    GuJia_Level = table.Column<int>(nullable: true),
                    Cold_resistance = table.Column<int>(nullable: true),
                    Appearance_Level = table.Column<int>(nullable: true),
                    Friendly_Level = table.Column<int>(nullable: true),
                    Gluttonous_Level = table.Column<int>(nullable: true),
                    Sticky_Level = table.Column<int>(nullable: true),
                    Hairfalling_Level = table.Column<int>(nullable: true),
                    Call_Level = table.Column<int>(nullable: true),
                    CanTrain_Level = table.Column<int>(nullable: true),
                    Feed_difficulty = table.Column<int>(nullable: true),
                    Care_needs = table.Column<int>(nullable: true),
                    Base_Info = table.Column<string>(nullable: true),
                    Variety_charact = table.Column<string>(nullable: true),
                    Nurs_knowledge = table.Column<string>(nullable: true),
                    Need_Care = table.Column<string>(nullable: true),
                    AniMalCategoryID = table.Column<int>(nullable: true),
                    PetCategory_Photos = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PetCategory_Introduce = table.Column<string>(unicode: false, maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCategory", x => x.PetCategoryID);
                    table.ForeignKey(
                        name: "FK_PetCategory_AnimalCategory",
                        column: x => x.AniMalCategoryID,
                        principalTable: "AnimalCategory",
                        principalColumn: "AnimalCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoveShowPhotos",
                columns: table => new
                {
                    LoveShowPhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LspTitle = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    LspContent = table.Column<string>(unicode: false, nullable: true),
                    Image1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Image2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Image3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Image4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LspCreateUserID = table.Column<int>(nullable: true),
                    LspCategoryID = table.Column<int>(nullable: true),
                    BrowseNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    GiveZanNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Image5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Image6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ArticleCategoryID = table.Column<int>(nullable: true),
                    PhotoList = table.Column<string>(unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoveShowPhotos", x => x.LoveShowPhotoID);
                    table.ForeignKey(
                        name: "FK_LoveShowPhotos_User",
                        column: x => x.ArticleCategoryID,
                        principalTable: "ArticleCategory",
                        principalColumn: "ArticleCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoveShowVideos",
                columns: table => new
                {
                    LoveShowVideoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LsvTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LsvCotent = table.Column<string>(unicode: false, nullable: true),
                    LsvReleaseUserID = table.Column<int>(nullable: false),
                    LsvCategoryID = table.Column<int>(nullable: false),
                    LsvBrowseNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    GiveZanNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    LsvVideo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ArticleCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoveShowVideos", x => x.LoveShowVideoID);
                    table.ForeignKey(
                        name: "FK_LoveShowVideos_User",
                        column: x => x.ArticleCategoryID,
                        principalTable: "ArticleCategory",
                        principalColumn: "ArticleCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AreaForCityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaID);
                    table.ForeignKey(
                        name: "FK_Area_City",
                        column: x => x.AreaForCityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopType",
                columns: table => new
                {
                    ShopTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Shop_Price = table.Column<double>(nullable: true),
                    Mark_Price = table.Column<double>(nullable: true),
                    For_ShopID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopType", x => x.ShopTypeID);
                    table.ForeignKey(
                        name: "FK_ShopType_LuoKiShop",
                        column: x => x.For_ShopID,
                        principalTable: "LuoKiShop",
                        principalColumn: "ShopID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetPositionSymptom",
                columns: table => new
                {
                    PetPositionSymptomID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SymptomName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    For_PetPositionID = table.Column<int>(nullable: true),
                    Describe = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetPositionSymptom", x => x.PetPositionSymptomID);
                    table.ForeignKey(
                        name: "FK_PetPositionSymptom_PetPosition",
                        column: x => x.For_PetPositionID,
                        principalTable: "PetPosition",
                        principalColumn: "PetPositionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceShop",
                columns: table => new
                {
                    PetServiceShopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PetServiceShopName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ShopPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ShopAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    AddressJWD = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BusinessHours = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HasBath = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    HasDesigner = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    HasFoster = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    HasMedicalCare = table.Column<int>(name: "HasMedical-Care", nullable: true, defaultValueSql: "((0))"),
                    ShopImage1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImage2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImage3 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImage4 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImage5 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShopImage6 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HasDogService = table.Column<int>(nullable: true),
                    HasCatService = table.Column<int>(nullable: true),
                    For_CityID = table.Column<int>(nullable: true),
                    For_AreaID = table.Column<int>(nullable: true),
                    For_UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceShop", x => x.PetServiceShopID);
                    table.ForeignKey(
                        name: "FK_PetServiceShop_Area",
                        column: x => x.For_AreaID,
                        principalTable: "Area",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceShop_City",
                        column: x => x.For_CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Sex = table.Column<string>(unicode: false, maxLength: 2, nullable: true, defaultValueSql: "('check Sex in(''男'',''女'')')"),
                    UserPhotos = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    RegisterPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Identity = table.Column<int>(nullable: true),
                    For_CityID = table.Column<int>(nullable: true),
                    For_AreaID = table.Column<int>(nullable: true),
                    User_BoQiMoney = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    UserIntroduce = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Expertise = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QQAccess_Token = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QQOpenId = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Area",
                        column: x => x.For_AreaID,
                        principalTable: "Area",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_City",
                        column: x => x.For_CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetDisease",
                columns: table => new
                {
                    DiseaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Genera = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Symptom = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Summary = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    DiseaseCause = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    MainSymptom = table.Column<string>(unicode: false, nullable: true),
                    ZDBZ = table.Column<string>(unicode: false, nullable: true),
                    Treatment = table.Column<string>(unicode: false, nullable: true),
                    DiseaseName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ForPetCaegoryID = table.Column<int>(name: "For-PetCaegoryID", nullable: true),
                    ForEN = table.Column<string>(name: "For-EN", unicode: false, maxLength: 2, nullable: true),
                    Type = table.Column<int>(nullable: true),
                    For_SymptomID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetDisease", x => x.DiseaseID);
                    table.ForeignKey(
                        name: "FK_PetDisease_PetPositionSymptom",
                        column: x => x.For_SymptomID,
                        principalTable: "PetPositionSymptom",
                        principalColumn: "PetPositionSymptomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopServiceProject",
                columns: table => new
                {
                    ShopServicesItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_ShopID = table.Column<int>(nullable: true),
                    ServiceCategoryID = table.Column<int>(nullable: true),
                    ServiceItemName = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    SaleNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    MinPrice = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopServiceProject", x => x.ShopServicesItemID);
                    table.ForeignKey(
                        name: "FK_ShopServiceProject_PetServiceShop",
                        column: x => x.For_ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopServiceProject_ServiceCaegory",
                        column: x => x.ServiceCategoryID,
                        principalTable: "ServiceCaegory",
                        principalColumn: "Service_CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActiveWork",
                columns: table => new
                {
                    ActiveWorkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkUserID = table.Column<int>(nullable: true),
                    Photo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Introduce = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    For_ActiveID = table.Column<int>(nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    SupportNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    WorkUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveWork", x => x.ActiveWorkID);
                    table.ForeignKey(
                        name: "FK_ActiveWork_PetActive",
                        column: x => x.WorkUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassArticle",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleTitle = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Photo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Introduce = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CreateUserID = table.Column<int>(nullable: true),
                    IsManager = table.Column<int>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ArticleCategoryID = table.Column<int>(nullable: true),
                    BrowserNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    IsHot = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassArticle", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_ClassArticle_User",
                        column: x => x.CreateUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentTargetID = table.Column<int>(nullable: true),
                    CommentUserID = table.Column<int>(nullable: true),
                    CommentTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CommentContent = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CommentCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_CommentCategory",
                        column: x => x.CommentCategoryID,
                        principalTable: "CommentCategory",
                        principalColumn: "CommentCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_User",
                        column: x => x.CommentUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GetPet",
                columns: table => new
                {
                    GetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PubTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PetCategoryID = table.Column<int>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    HasInject = table.Column<int>(nullable: true),
                    HairColor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    GetContent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    PubArea = table.Column<string>(unicode: false, nullable: true),
                    GetPic = table.Column<string>(unicode: false, nullable: true),
                    Feature = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    GName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    GPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    PetName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    GetUserID = table.Column<int>(nullable: true),
                    flag = table.Column<int>(nullable: true),
                    PutUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetPet", x => x.GetID);
                    table.ForeignKey(
                        name: "FK_GetPet_User",
                        column: x => x.GetUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GetPet_PetCategory",
                        column: x => x.PetCategoryID,
                        principalTable: "PetCategory",
                        principalColumn: "PetCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LostPet",
                columns: table => new
                {
                    LostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PubTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PetCategoryID = table.Column<int>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    HasBrand = table.Column<int>(nullable: true),
                    HairColor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    LostContent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    PetName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    PubArea = table.Column<string>(unicode: false, nullable: true),
                    LostPic = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LostTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    LDescription = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    LostUserID = table.Column<int>(nullable: true),
                    LName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    flag = table.Column<int>(nullable: true),
                    PutUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LostPet", x => x.LostID);
                    table.ForeignKey(
                        name: "FK_LostPet_User",
                        column: x => x.LostUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LostPet_PetCategory",
                        column: x => x.PetCategoryID,
                        principalTable: "PetCategory",
                        principalColumn: "PetCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemPet",
                columns: table => new
                {
                    MemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    MemAgent = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    MemArea = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    MemPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    MemPic = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MemGroup = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    MemAffair = table.Column<string>(unicode: false, maxLength: 2000, nullable: true),
                    MemPhoto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MemUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemPet", x => x.MemID);
                    table.ForeignKey(
                        name: "FK_MemPet_User",
                        column: x => x.MemUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetInformation",
                columns: table => new
                {
                    PetInformationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Photo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Introduce = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CreateUserID = table.Column<int>(nullable: true),
                    IsManage = table.Column<int>(nullable: true),
                    Content = table.Column<string>(unicode: false, nullable: true),
                    InfoCategoryID = table.Column<int>(nullable: true),
                    BrowserNum = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    IsHot = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetInformation", x => x.PetInformationID);
                    table.ForeignKey(
                        name: "FK_PetInformation_User",
                        column: x => x.CreateUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetRl",
                columns: table => new
                {
                    PetRlID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PSex = table.Column<int>(nullable: true),
                    PSalary = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PResidence = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    PPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    PTitle = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PContent = table.Column<string>(unicode: false, nullable: true),
                    PISLook = table.Column<int>(nullable: true),
                    PISID = table.Column<int>(nullable: true),
                    PISSterilisation = table.Column<int>(nullable: true),
                    RlUserID = table.Column<int>(nullable: true),
                    For_GetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetRl", x => x.PetRlID);
                    table.ForeignKey(
                        name: "FK_PetRl_User",
                        column: x => x.RlUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceCarts",
                columns: table => new
                {
                    PetServiceCartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_UserID = table.Column<int>(nullable: true),
                    For_ShopID = table.Column<int>(nullable: true),
                    ServiceAmount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceCarts", x => x.PetServiceCartID);
                    table.ForeignKey(
                        name: "FK_PetServiceCarts_PetServiceShop",
                        column: x => x.For_ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceCarts_User",
                        column: x => x.For_UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceOrder",
                columns: table => new
                {
                    PetServiceOrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_UserID = table.Column<int>(nullable: true),
                    For_ShopID = table.Column<int>(nullable: true),
                    OrderState = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OrderTotalMoney = table.Column<double>(nullable: true),
                    OrderCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OrderContactPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OrderServiceNum = table.Column<int>(nullable: true),
                    OrderTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceOrder", x => x.PetServiceOrderID);
                    table.ForeignKey(
                        name: "FK_PetServiceOrder_PetServiceShop",
                        column: x => x.For_ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceOrder_User",
                        column: x => x.For_UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PickPet",
                columns: table => new
                {
                    PickID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PubTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PetCategoryID = table.Column<int>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    HasBrand = table.Column<int>(nullable: true),
                    HairColor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    PickContent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PubArea = table.Column<string>(unicode: false, nullable: true),
                    PickPic = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PickUserID = table.Column<int>(nullable: true),
                    PIName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    PIPhone = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    PIDescription = table.Column<string>(unicode: false, nullable: true),
                    PITime = table.Column<DateTime>(type: "datetime", nullable: true),
                    flag = table.Column<int>(nullable: true),
                    PutUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickPet", x => x.PickID);
                    table.ForeignKey(
                        name: "FK_PickPet_PetCategory",
                        column: x => x.PetCategoryID,
                        principalTable: "PetCategory",
                        principalColumn: "PetCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PickPet_User",
                        column: x => x.PickUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceShopCollection",
                columns: table => new
                {
                    CollectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: true),
                    ShopID = table.Column<int>(nullable: true),
                    Time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceShopCollection", x => x.CollectionID);
                    table.ForeignKey(
                        name: "FK_ServiceShopCollection_PetServiceShop",
                        column: x => x.ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceShopCollection_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPackage",
                columns: table => new
                {
                    ProjectPackageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_ProjectID = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    PackgelName = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    For_ShopID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPackage", x => x.ProjectPackageID);
                    table.ForeignKey(
                        name: "FK_ProjectPackage_ShopServiceProject",
                        column: x => x.For_ProjectID,
                        principalTable: "ShopServiceProject",
                        principalColumn: "ShopServicesItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupportWork",
                columns: table => new
                {
                    SupportWorkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupportUserID = table.Column<int>(nullable: true),
                    For_WorkID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportWork", x => x.SupportWorkID);
                    table.ForeignKey(
                        name: "FK_SupportWork_ActiveWork",
                        column: x => x.For_WorkID,
                        principalTable: "ActiveWork",
                        principalColumn: "ActiveWorkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassArticleCollection",
                columns: table => new
                {
                    CollectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: true),
                    ArticleID = table.Column<int>(nullable: true),
                    Time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassArticleCollection", x => x.CollectionID);
                    table.ForeignKey(
                        name: "FK_ClassArticleCollection_ClassArticle",
                        column: x => x.ArticleID,
                        principalTable: "ClassArticle",
                        principalColumn: "ArticleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassArticleCollection_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reply",
                columns: table => new
                {
                    ReplyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplyTargetID = table.Column<int>(nullable: true),
                    ReplyUserID = table.Column<int>(nullable: true),
                    ReplayTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Reply_CommentID = table.Column<int>(nullable: true),
                    ReplyContent = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reply", x => x.ReplyID);
                    table.ForeignKey(
                        name: "FK_Reply_Comment",
                        column: x => x.Reply_CommentID,
                        principalTable: "Comment",
                        principalColumn: "CommentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reply_User",
                        column: x => x.ReplyTargetID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reply_User1",
                        column: x => x.ReplyUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetInformationCollection",
                columns: table => new
                {
                    CollectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: true),
                    ArticleID = table.Column<int>(nullable: true),
                    Time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetInformationCollection", x => x.CollectionID);
                    table.ForeignKey(
                        name: "FK_PetInformationCollection_PetInformation",
                        column: x => x.ArticleID,
                        principalTable: "PetInformation",
                        principalColumn: "PetInformationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetInformationCollection_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FWShopComment",
                columns: table => new
                {
                    FWShopCommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentUserID = table.Column<int>(nullable: true),
                    CommentContent = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Score = table.Column<double>(nullable: true),
                    For_PackageID = table.Column<int>(nullable: true),
                    For_ShopID = table.Column<int>(nullable: true),
                    For_ServiceProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FWShopComment", x => x.FWShopCommentID);
                    table.ForeignKey(
                        name: "FK_FWShopComment_User",
                        column: x => x.CommentUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FWShopComment_ProjectPackage",
                        column: x => x.For_PackageID,
                        principalTable: "ProjectPackage",
                        principalColumn: "ProjectPackageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FWShopComment_ShopServiceProject",
                        column: x => x.For_ServiceProjectID,
                        principalTable: "ShopServiceProject",
                        principalColumn: "ShopServicesItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FWShopComment_PetServiceShop",
                        column: x => x.For_ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceCartDetails",
                columns: table => new
                {
                    PetServiceCartDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_ShopID = table.Column<int>(nullable: true),
                    For_ServiceProjectID = table.Column<int>(nullable: true),
                    For_ProjectPackageID = table.Column<int>(nullable: true),
                    For_UserID = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    Amount = table.Column<int>(nullable: true),
                    Detailed = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    For_PetServiceCartID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceCartDetails", x => x.PetServiceCartDetailID);
                    table.ForeignKey(
                        name: "FK_PetServiceCartDetails_PetServiceCartDetails",
                        column: x => x.For_PetServiceCartID,
                        principalTable: "PetServiceCarts",
                        principalColumn: "PetServiceCartID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceCart_ProjectPackage",
                        column: x => x.For_ProjectPackageID,
                        principalTable: "ProjectPackage",
                        principalColumn: "ProjectPackageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceCart_ShopServiceProject",
                        column: x => x.For_ServiceProjectID,
                        principalTable: "ShopServiceProject",
                        principalColumn: "ShopServicesItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceCart_PetServiceShop1",
                        column: x => x.For_ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceCart_User",
                        column: x => x.For_UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceOrderDetails",
                columns: table => new
                {
                    PetServiceOrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    For_ShopID = table.Column<int>(nullable: true),
                    For_ServiceProjectID = table.Column<int>(nullable: true),
                    For_UserID = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    Amount = table.Column<int>(nullable: true),
                    Detailed = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    For_PetServiceOrderID = table.Column<int>(nullable: true),
                    For_ProjectPackageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceOrderDetails", x => x.PetServiceOrderDetailID);
                    table.ForeignKey(
                        name: "FK_PetServiceOrderDetails_ProjectPackage",
                        column: x => x.For_ProjectPackageID,
                        principalTable: "ProjectPackage",
                        principalColumn: "ProjectPackageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceOrderDetails_ShopServiceProject",
                        column: x => x.For_ServiceProjectID,
                        principalTable: "ShopServiceProject",
                        principalColumn: "ShopServicesItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceOrderDetails_PetServiceShop",
                        column: x => x.For_ShopID,
                        principalTable: "PetServiceShop",
                        principalColumn: "PetServiceShopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetServiceOrderDetails_User",
                        column: x => x.For_UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveWork_WorkUserID",
                table: "ActiveWork",
                column: "WorkUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Area_AreaForCityID",
                table: "Area",
                column: "AreaForCityID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassArticle_CreateUserID",
                table: "ClassArticle",
                column: "CreateUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassArticleCollection_ArticleID",
                table: "ClassArticleCollection",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassArticleCollection_UserID",
                table: "ClassArticleCollection",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CommentCategoryID",
                table: "Comment",
                column: "CommentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CommentUserID",
                table: "Comment",
                column: "CommentUserID");

            migrationBuilder.CreateIndex(
                name: "IX_FWShopComment_CommentUserID",
                table: "FWShopComment",
                column: "CommentUserID");

            migrationBuilder.CreateIndex(
                name: "IX_FWShopComment_For_PackageID",
                table: "FWShopComment",
                column: "For_PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_FWShopComment_For_ServiceProjectID",
                table: "FWShopComment",
                column: "For_ServiceProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_FWShopComment_For_ShopID",
                table: "FWShopComment",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_GetPet_GetUserID",
                table: "GetPet",
                column: "GetUserID");

            migrationBuilder.CreateIndex(
                name: "IX_GetPet_PetCategoryID",
                table: "GetPet",
                column: "PetCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_LostPet_LostUserID",
                table: "LostPet",
                column: "LostUserID");

            migrationBuilder.CreateIndex(
                name: "IX_LostPet_PetCategoryID",
                table: "LostPet",
                column: "PetCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_LoveShowPhotos_ArticleCategoryID",
                table: "LoveShowPhotos",
                column: "ArticleCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_LoveShowVideos_ArticleCategoryID",
                table: "LoveShowVideos",
                column: "ArticleCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MemPet_MemUserID",
                table: "MemPet",
                column: "MemUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetCategory_AniMalCategoryID",
                table: "PetCategory",
                column: "AniMalCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PetDisease_For_SymptomID",
                table: "PetDisease",
                column: "For_SymptomID");

            migrationBuilder.CreateIndex(
                name: "IX_PetInformation_CreateUserID",
                table: "PetInformation",
                column: "CreateUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetInformationCollection_ArticleID",
                table: "PetInformationCollection",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_PetInformationCollection_UserID",
                table: "PetInformationCollection",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetPositionSymptom_For_PetPositionID",
                table: "PetPositionSymptom",
                column: "For_PetPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_PetRl_RlUserID",
                table: "PetRl",
                column: "RlUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCartDetails_For_PetServiceCartID",
                table: "PetServiceCartDetails",
                column: "For_PetServiceCartID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCartDetails_For_ProjectPackageID",
                table: "PetServiceCartDetails",
                column: "For_ProjectPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCartDetails_For_ServiceProjectID",
                table: "PetServiceCartDetails",
                column: "For_ServiceProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCartDetails_For_ShopID",
                table: "PetServiceCartDetails",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCartDetails_For_UserID",
                table: "PetServiceCartDetails",
                column: "For_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCarts_For_ShopID",
                table: "PetServiceCarts",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceCarts_For_UserID",
                table: "PetServiceCarts",
                column: "For_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceOrder_For_ShopID",
                table: "PetServiceOrder",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceOrder_For_UserID",
                table: "PetServiceOrder",
                column: "For_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceOrderDetails_For_ProjectPackageID",
                table: "PetServiceOrderDetails",
                column: "For_ProjectPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceOrderDetails_For_ServiceProjectID",
                table: "PetServiceOrderDetails",
                column: "For_ServiceProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceOrderDetails_For_ShopID",
                table: "PetServiceOrderDetails",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceOrderDetails_For_UserID",
                table: "PetServiceOrderDetails",
                column: "For_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceShop_For_AreaID",
                table: "PetServiceShop",
                column: "For_AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceShop_For_CityID",
                table: "PetServiceShop",
                column: "For_CityID");

            migrationBuilder.CreateIndex(
                name: "IX_PickPet_PetCategoryID",
                table: "PickPet",
                column: "PetCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PickPet_PickUserID",
                table: "PickPet",
                column: "PickUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPackage_For_ProjectID",
                table: "ProjectPackage",
                column: "For_ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_Reply_CommentID",
                table: "Reply",
                column: "Reply_CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_ReplyTargetID",
                table: "Reply",
                column: "ReplyTargetID");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_ReplyUserID",
                table: "Reply",
                column: "ReplyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceShopCollection_ShopID",
                table: "ServiceShopCollection",
                column: "ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceShopCollection_UserID",
                table: "ServiceShopCollection",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ShopServiceProject_For_ShopID",
                table: "ShopServiceProject",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_ShopServiceProject_ServiceCategoryID",
                table: "ShopServiceProject",
                column: "ServiceCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ShopType_For_ShopID",
                table: "ShopType",
                column: "For_ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_SupportWork_For_WorkID",
                table: "SupportWork",
                column: "For_WorkID");

            migrationBuilder.CreateIndex(
                name: "IX_User_For_AreaID",
                table: "User",
                column: "For_AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_User_For_CityID",
                table: "User",
                column: "For_CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "AnimalFengLei");

            migrationBuilder.DropTable(
                name: "AppPetArticle");

            migrationBuilder.DropTable(
                name: "ArticleOperation");

            migrationBuilder.DropTable(
                name: "ClassArticleCollection");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "DeliveryAddress");

            migrationBuilder.DropTable(
                name: "EnCategory");

            migrationBuilder.DropTable(
                name: "FindLostPet");

            migrationBuilder.DropTable(
                name: "FindPickPet");

            migrationBuilder.DropTable(
                name: "FWShopComment");

            migrationBuilder.DropTable(
                name: "GetPet");

            migrationBuilder.DropTable(
                name: "LostPet");

            migrationBuilder.DropTable(
                name: "LoveShowPhotos");

            migrationBuilder.DropTable(
                name: "LoveShowVideos");

            migrationBuilder.DropTable(
                name: "MArea");

            migrationBuilder.DropTable(
                name: "MCity");

            migrationBuilder.DropTable(
                name: "MemPet");

            migrationBuilder.DropTable(
                name: "MNode");

            migrationBuilder.DropTable(
                name: "MPetServiceShop");

            migrationBuilder.DropTable(
                name: "MPetServiceShopOrder");

            migrationBuilder.DropTable(
                name: "MServicePackage");

            migrationBuilder.DropTable(
                name: "MServiceShopOrderDetails");

            migrationBuilder.DropTable(
                name: "MShopService");

            migrationBuilder.DropTable(
                name: "MShopServiceCate");

            migrationBuilder.DropTable(
                name: "PetActive");

            migrationBuilder.DropTable(
                name: "PetDisease");

            migrationBuilder.DropTable(
                name: "PetInformationCollection");

            migrationBuilder.DropTable(
                name: "PetProblem");

            migrationBuilder.DropTable(
                name: "PetRl");

            migrationBuilder.DropTable(
                name: "PetServiceCartDetails");

            migrationBuilder.DropTable(
                name: "PetServiceOrder");

            migrationBuilder.DropTable(
                name: "PetServiceOrderDetails");

            migrationBuilder.DropTable(
                name: "PickPet");

            migrationBuilder.DropTable(
                name: "ReceivingAddress");

            migrationBuilder.DropTable(
                name: "Reply");

            migrationBuilder.DropTable(
                name: "ServiceShopCollection");

            migrationBuilder.DropTable(
                name: "ShopCart");

            migrationBuilder.DropTable(
                name: "ShopType");

            migrationBuilder.DropTable(
                name: "SupportWork");

            migrationBuilder.DropTable(
                name: "UserFriendly");

            migrationBuilder.DropTable(
                name: "ClassArticle");

            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "PetPositionSymptom");

            migrationBuilder.DropTable(
                name: "PetInformation");

            migrationBuilder.DropTable(
                name: "PetServiceCarts");

            migrationBuilder.DropTable(
                name: "ProjectPackage");

            migrationBuilder.DropTable(
                name: "PetCategory");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "LuoKiShop");

            migrationBuilder.DropTable(
                name: "ActiveWork");

            migrationBuilder.DropTable(
                name: "PetPosition");

            migrationBuilder.DropTable(
                name: "ShopServiceProject");

            migrationBuilder.DropTable(
                name: "AnimalCategory");

            migrationBuilder.DropTable(
                name: "CommentCategory");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PetServiceShop");

            migrationBuilder.DropTable(
                name: "ServiceCaegory");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
