namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRestaurantsTableSetMaxLengthForTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Slug", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Slogan", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Slogan", c => c.String());
            AlterColumn("dbo.Restaurants", "Slug", c => c.String());
            AlterColumn("dbo.Restaurants", "Name", c => c.String());
        }
    }
}
