namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBranchesTableSetMaxLengthForTextColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branches", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Branches", "Slug", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Branches", "Slug", c => c.String());
            AlterColumn("dbo.Branches", "Name", c => c.String());
        }
    }
}
