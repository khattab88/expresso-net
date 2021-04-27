namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Role = c.Int(nullable: false),
                        Password = c.String(),
                        PasswordConfirm = c.String(),
                        PasswordChangedAt = c.DateTime(nullable: false),
                        PasswordResetToken = c.String(),
                        PasswordResetExpiresAt = c.DateTime(nullable: false),
                        Mobile = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
