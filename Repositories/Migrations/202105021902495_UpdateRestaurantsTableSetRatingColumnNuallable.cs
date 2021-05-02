namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRestaurantsTableSetRatingColumnNuallable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurants", "Rating", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Rating", c => c.Single(nullable: false));
        }
    }
}
