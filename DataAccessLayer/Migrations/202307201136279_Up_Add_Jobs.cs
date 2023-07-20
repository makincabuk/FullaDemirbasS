namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_Add_Jobs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobsID = c.Int(nullable: false, identity: true),
                        JobsName = c.String(maxLength: 200),
                        JobsDescription = c.String(maxLength: 200),
                        JobsStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JobsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jobs");
        }
    }
}
