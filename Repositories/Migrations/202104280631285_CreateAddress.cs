namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        Street = c.String(),
                        Building = c.String(),
                        Floor = c.String(),
                        Apartment = c.String(),
                        Mobile = c.String(),
                        Instructions = c.String(),
                        UserId = c.Guid(nullable: false),
                        AreaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.AreaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "UserId", "dbo.Users");
            DropForeignKey("dbo.Addresses", "AreaId", "dbo.Areas");
            DropIndex("dbo.Addresses", new[] { "AreaId" });
            DropIndex("dbo.Addresses", new[] { "UserId" });
            DropTable("dbo.Addresses");
        }
    }
}
