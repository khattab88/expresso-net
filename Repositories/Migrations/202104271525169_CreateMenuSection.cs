namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMenuSection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuSections",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        MenuId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuSections", "MenuId", "dbo.Menus");
            DropIndex("dbo.MenuSections", new[] { "MenuId" });
            DropTable("dbo.MenuSections");
        }
    }
}
