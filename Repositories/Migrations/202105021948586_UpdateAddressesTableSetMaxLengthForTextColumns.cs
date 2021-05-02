namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAddressesTableSetMaxLengthForTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Name", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Building", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Floor", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Apartment", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Mobile", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Instructions", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "Instructions", c => c.String());
            AlterColumn("dbo.Addresses", "Mobile", c => c.String());
            AlterColumn("dbo.Addresses", "Apartment", c => c.String());
            AlterColumn("dbo.Addresses", "Floor", c => c.String());
            AlterColumn("dbo.Addresses", "Building", c => c.String());
            AlterColumn("dbo.Addresses", "Street", c => c.String());
            AlterColumn("dbo.Addresses", "Name", c => c.String());
        }
    }
}
