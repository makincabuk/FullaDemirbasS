namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_FixtureModel_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FixtureModels",
                c => new
                    {
                        FixtureModelId = c.Int(nullable: false, identity: true),
                        FixtureModelName = c.String(maxLength: 100),
                        SubCategoryId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        FixtureModelStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FixtureModelId)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.SubCategoryId)
                .Index(t => t.ModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FixtureModels", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.FixtureModels", "ModelId", "dbo.Models");
            DropIndex("dbo.FixtureModels", new[] { "ModelId" });
            DropIndex("dbo.FixtureModels", new[] { "SubCategoryId" });
            DropTable("dbo.FixtureModels");
        }
    }
}
