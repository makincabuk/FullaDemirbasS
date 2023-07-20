namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "EmployeeId", c => c.Int());
            CreateIndex("dbo.Contents", "EmployeeId");
            AddForeignKey("dbo.Contents", "EmployeeId", "dbo.Employees", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Contents", new[] { "EmployeeId" });
            DropColumn("dbo.Contents", "EmployeeId");
        }
    }
}
