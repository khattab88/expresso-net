namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAreasTableSetTextColumnsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Areas", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Areas", "Slug", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Areas", "Slug", c => c.String(maxLength: 50));
            AlterColumn("dbo.Areas", "Name", c => c.String(maxLength: 50));
        }
    }
}
