namespace SegurosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        GenderType = c.Int(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        InitialDate = c.DateTime(nullable: false),
                        CoverTime = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RiskLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);            
        }
        
        public override void Down()
        {
            this.DropTable("dbo.Policies");
            this.DropTable("dbo.Clients");
        }
    }
}
