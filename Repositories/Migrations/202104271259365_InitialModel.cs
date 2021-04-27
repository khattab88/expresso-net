namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Slug = c.String(),
                        CityId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Slug = c.String(),
                        CountryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Slug = c.String(),
                        Alias = c.String(),
                        Image = c.String(),
                        Currency = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Slug = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Slug = c.String(),
                        Slogan = c.String(),
                        Logo = c.String(),
                        Image = c.String(),
                        DeliveryTime = c.Byte(nullable: false),
                        DeliveryFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpecialOffres = c.Boolean(nullable: false),
                        Rating = c.Single(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RestaurantTags",
                c => new
                    {
                        Tag_Id = c.Guid(nullable: false),
                        Restaurant_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Restaurant_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Restaurant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurantTags", "Restaurant_Id", "dbo.Restaurants");
            DropForeignKey("dbo.RestaurantTags", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.Restaurants", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Areas", "CityId", "dbo.Cities");
            DropIndex("dbo.RestaurantTags", new[] { "Restaurant_Id" });
            DropIndex("dbo.RestaurantTags", new[] { "Tag_Id" });
            DropIndex("dbo.Restaurants", new[] { "CategoryId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Areas", new[] { "CityId" });
            DropTable("dbo.RestaurantTags");
            DropTable("dbo.Tags");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Categories");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Areas");
        }
    }
}
