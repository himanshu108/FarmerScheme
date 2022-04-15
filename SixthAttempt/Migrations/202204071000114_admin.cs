namespace SixthAttempt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insurence",
                c => new
                    {
                        companyID = c.Int(nullable: false, identity: true),
                        companyName = c.String(nullable: false, maxLength: 12),
                        city = c.String(nullable: false, maxLength: 12),
                        ownerOfCompany = c.String(nullable: false, maxLength: 12),
                    })
                .PrimaryKey(t => t.companyID);
            
            AddColumn("dbo.Farmer", "myInsurence_companyID", c => c.Int());
            CreateIndex("dbo.Farmer", "myInsurence_companyID");
            AddForeignKey("dbo.Farmer", "myInsurence_companyID", "dbo.Insurence", "companyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Farmer", "myInsurence_companyID", "dbo.Insurence");
            DropIndex("dbo.Farmer", new[] { "myInsurence_companyID" });
            DropColumn("dbo.Farmer", "myInsurence_companyID");
            DropTable("dbo.Insurence");
        }
    }
}
