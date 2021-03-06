namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTagsTableSetNameColumnRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tags", "Name", c => c.String());
        }
    }
}
