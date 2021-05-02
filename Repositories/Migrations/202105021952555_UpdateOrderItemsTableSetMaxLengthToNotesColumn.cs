namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderItemsTableSetMaxLengthToNotesColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderItems", "Notes", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "Notes", c => c.String());
        }
    }
}
