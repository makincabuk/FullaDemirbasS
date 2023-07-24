namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_Fixture_1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fixtures", "UserId", "dbo.Users");
            DropIndex("dbo.Fixtures", new[] { "UserId" });
            RenameColumn(table: "dbo.Fixtures", name: "UserId", newName: "User_UserID");
            AddColumn("dbo.Fixtures", "ModelId", c => c.Int(nullable: false));
            AddColumn("dbo.Fixtures", "FixtureStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Fixtures", "User_UserID", c => c.Int());
            CreateIndex("dbo.Fixtures", "ModelId");
            CreateIndex("dbo.Fixtures", "User_UserID");
            AddForeignKey("dbo.Fixtures", "ModelId", "dbo.Models", "ModelID", cascadeDelete: true);
            AddForeignKey("dbo.Fixtures", "User_UserID", "dbo.Users", "UserID");
            DropColumn("dbo.Fixtures", "UserStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fixtures", "UserStatus", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Fixtures", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Fixtures", "ModelId", "dbo.Models");
            DropIndex("dbo.Fixtures", new[] { "User_UserID" });
            DropIndex("dbo.Fixtures", new[] { "ModelId" });
            AlterColumn("dbo.Fixtures", "User_UserID", c => c.Int(nullable: false));
            DropColumn("dbo.Fixtures", "FixtureStatus");
            DropColumn("dbo.Fixtures", "ModelId");
            RenameColumn(table: "dbo.Fixtures", name: "User_UserID", newName: "UserId");
            CreateIndex("dbo.Fixtures", "UserId");
            AddForeignKey("dbo.Fixtures", "UserId", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
