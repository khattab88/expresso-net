namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMenuItemOptionItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItemOptionItems",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Value = c.Double(nullable: false),
                        MenuItemOptionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItemOptions", t => t.MenuItemOptionId, cascadeDelete: true)
                .Index(t => t.MenuItemOptionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItemOptionItems", "MenuItemOptionId", "dbo.MenuItemOptions");
            DropIndex("dbo.MenuItemOptionItems", new[] { "MenuItemOptionId" });
            DropTable("dbo.MenuItemOptionItems");
        }
    }
}
