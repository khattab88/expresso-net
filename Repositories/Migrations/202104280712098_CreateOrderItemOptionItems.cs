namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderItemOptionItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItemOptionItems",
                c => new
                    {
                        OrderItemOption_Id = c.Guid(nullable: false),
                        MenuItemOptionItem_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderItemOption_Id, t.MenuItemOptionItem_Id })
                .ForeignKey("dbo.OrderItemOptions", t => t.OrderItemOption_Id, cascadeDelete: true)
                .ForeignKey("dbo.MenuItemOptionItems", t => t.MenuItemOptionItem_Id, cascadeDelete: false)
                .Index(t => t.OrderItemOption_Id)
                .Index(t => t.MenuItemOptionItem_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItemOptionItems", "MenuItemOptionItem_Id", "dbo.MenuItemOptionItems");
            DropForeignKey("dbo.OrderItemOptionItems", "OrderItemOption_Id", "dbo.OrderItemOptions");
            DropIndex("dbo.OrderItemOptionItems", new[] { "MenuItemOptionItem_Id" });
            DropIndex("dbo.OrderItemOptionItems", new[] { "OrderItemOption_Id" });
            DropTable("dbo.OrderItemOptionItems");
        }
    }
}
