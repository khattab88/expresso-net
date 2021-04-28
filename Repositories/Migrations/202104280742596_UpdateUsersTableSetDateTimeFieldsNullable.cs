namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsersTableSetDateTimeFieldsNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "PasswordChangedAt", c => c.DateTime());
            AlterColumn("dbo.Users", "PasswordResetExpiresAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PasswordResetExpiresAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "PasswordChangedAt", c => c.DateTime(nullable: false));
        }
    }
}
