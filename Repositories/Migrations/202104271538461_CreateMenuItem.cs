namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMenuItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image = c.String(),
                        Description = c.String(),
                        MenuSectionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuSections", t => t.MenuSectionId, cascadeDelete: true)
                .Index(t => t.MenuSectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "MenuSectionId", "dbo.MenuSections");
            DropIndex("dbo.MenuItems", new[] { "MenuSectionId" });
            DropTable("dbo.MenuItems");
        }
    }
}
