namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBranch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Slug = c.String(),
                        RestaurantId = c.Guid(nullable: false),
                        AreaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId)
                .Index(t => t.AreaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Branches", "AreaId", "dbo.Areas");
            DropIndex("dbo.Branches", new[] { "AreaId" });
            DropIndex("dbo.Branches", new[] { "RestaurantId" });
            DropTable("dbo.Branches");
        }
    }
}
