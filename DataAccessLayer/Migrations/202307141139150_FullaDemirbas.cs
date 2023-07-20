namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullaDemirbas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutDetails1 = c.String(maxLength: 500),
                        AboutDetails2 = c.String(maxLength: 500),
                        AboutImage1 = c.String(maxLength: 1000),
                        AboutImage2 = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminUsername = c.String(maxLength: 200),
                        AdminUserPassword = c.String(maxLength: 200),
                        AdminRole = c.String(maxLength: 1),
                        AdminStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(maxLength: 100),
                        BrandStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 100),
                        CategoryDescription = c.String(maxLength: 200),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryID = c.Int(nullable: false, identity: true),
                        SubCategoryName = c.String(maxLength: 100),
                        SubCategoryDescription = c.String(),
                        SubCategoryStatus = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubCategoryID)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Fixtures",
                c => new
                    {
                        FixtureId = c.Int(nullable: false, identity: true),
                        FixtureName = c.String(maxLength: 100),
                        FixtureSeriNo = c.String(maxLength: 100),
                        FixtureModelNo = c.String(maxLength: 100),
                        FixtureImei1 = c.String(maxLength: 100),
                        FixtureImei2 = c.String(maxLength: 100),
                        FixtureMac1 = c.String(maxLength: 100),
                        FixtureMac2 = c.String(maxLength: 100),
                        FixtureDescription = c.String(maxLength: 1000),
                        UserId = c.Int(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                        UserStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FixtureId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SubCategoryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 100),
                        Uname = c.String(maxLength: 100),
                        USurName = c.String(maxLength: 100),
                        Usermage = c.String(maxLength: 100),
                        UserMail = c.String(maxLength: 100),
                        UserPhone = c.String(maxLength: 11),
                        UserStatus = c.Boolean(nullable: false),
                        UserPassword = c.String(),
                        StoreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Stores", t => t.StoreID, cascadeDelete: true)
                .Index(t => t.StoreID);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        StoreID = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                        StoreStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StoreID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        ModelName = c.String(maxLength: 100),
                        ModelStatus = c.Boolean(nullable: false),
                        BrandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelID)
                .ForeignKey("dbo.Brands", t => t.BrandID, cascadeDelete: true)
                .Index(t => t.BrandID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "BrandID", "dbo.Brands");
            DropForeignKey("dbo.Users", "StoreID", "dbo.Stores");
            DropForeignKey("dbo.Fixtures", "UserId", "dbo.Users");
            DropForeignKey("dbo.Fixtures", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Models", new[] { "BrandID" });
            DropIndex("dbo.Users", new[] { "StoreID" });
            DropIndex("dbo.Fixtures", new[] { "SubCategoryId" });
            DropIndex("dbo.Fixtures", new[] { "UserId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropTable("dbo.Models");
            DropTable("dbo.Stores");
            DropTable("dbo.Users");
            DropTable("dbo.Fixtures");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
