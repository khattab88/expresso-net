namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCountriesTableSetLengthToTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Countries", "Slug", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Countries", "Alias", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Countries", "Currency", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "Currency", c => c.String());
            AlterColumn("dbo.Countries", "Alias", c => c.String());
            AlterColumn("dbo.Countries", "Slug", c => c.String());
            AlterColumn("dbo.Countries", "Name", c => c.String());
        }
    }
}
