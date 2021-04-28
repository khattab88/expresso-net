namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Quantity = c.Int(nullable: false),
                        Notes = c.String(),
                        OrderId = c.Guid(nullable: false),
                        MenuItemId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.MenuItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "MenuItemId", "dbo.MenuItems");
            DropIndex("dbo.OrderItems", new[] { "MenuItemId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropTable("dbo.OrderItems");
        }
    }
}
