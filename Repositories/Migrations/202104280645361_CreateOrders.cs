namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeliveryFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Boolean(nullable: false),
                        Delivered = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        UserId = c.Guid(nullable: false),
                        BranchId = c.Guid(nullable: false),
                        AddressId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: false)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BranchId)
                .Index(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Orders", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "AddressId" });
            DropIndex("dbo.Orders", new[] { "BranchId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropTable("dbo.Orders");
        }
    }
}
