namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderItemOptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItemOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        OrderItemId = c.Guid(nullable: false),
                        MenuItemOptionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItemOptions", t => t.MenuItemOptionId, cascadeDelete: false)
                .ForeignKey("dbo.OrderItems", t => t.OrderItemId, cascadeDelete: true)
                .Index(t => t.OrderItemId)
                .Index(t => t.MenuItemOptionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItemOptions", "OrderItemId", "dbo.OrderItems");
            DropForeignKey("dbo.OrderItemOptions", "MenuItemOptionId", "dbo.MenuItemOptions");
            DropIndex("dbo.OrderItemOptions", new[] { "MenuItemOptionId" });
            DropIndex("dbo.OrderItemOptions", new[] { "OrderItemId" });
            DropTable("dbo.OrderItemOptions");
        }
    }
}
