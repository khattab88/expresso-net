namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenuItemsTableSetMaxLengthForTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuItems", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.MenuItems", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuItems", "Description", c => c.String());
            AlterColumn("dbo.MenuItems", "Name", c => c.String());
        }
    }
}
