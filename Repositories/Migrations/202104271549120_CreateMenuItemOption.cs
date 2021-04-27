namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMenuItemOption : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItemOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        MenuItemId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemId, cascadeDelete: true)
                .Index(t => t.MenuItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItemOptions", "MenuItemId", "dbo.MenuItems");
            DropIndex("dbo.MenuItemOptions", new[] { "MenuItemId" });
            DropTable("dbo.MenuItemOptions");
        }
    }
}
