namespace SegurosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPoliciesClientsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PolicyClients",
                c => new
                    {
                        Policy_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Policy_Id, t.Client_Id })
                .ForeignKey("dbo.Policies", t => t.Policy_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Policy_Id)
                .Index(t => t.Client_Id);
            
            AlterColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PolicyClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.PolicyClients", "Policy_Id", "dbo.Policies");
            DropIndex("dbo.PolicyClients", new[] { "Client_Id" });
            DropIndex("dbo.PolicyClients", new[] { "Policy_Id" });
            AlterColumn("dbo.Clients", "FirstName", c => c.String());
            DropTable("dbo.PolicyClients");
        }
    }
}
