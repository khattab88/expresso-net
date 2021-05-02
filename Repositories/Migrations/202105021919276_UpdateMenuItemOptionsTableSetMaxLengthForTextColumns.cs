namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenuItemOptionsTableSetMaxLengthForTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuItemOptions", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuItemOptions", "Name", c => c.String());
        }
    }
}
