namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenuSectionsTableSetMaxLengthForTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuSections", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuSections", "Name", c => c.String());
        }
    }
}
