using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class RestaurantConfiguration : EntityTypeConfiguration<Restaurant>
    {
        public RestaurantConfiguration()
        {
            // 1. Table overrides
            // ToTable("tbl_courses")


            // 2. Primary Key
            // HasKey(c => c.Id);


            // 3. Properties
            Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(r => r.Slug)
                .IsRequired()
                .HasMaxLength(50);

            Property(r => r.Slogan)
                .HasMaxLength(100);


            // 4. Relations

            // many-to-many (many restauarants => many tags)
            //HasMany(r => r.Tags)
            //    .WithMany(t => t.Restaurants)
            //    .Map(m =>
            //    {
            //        m.ToTable("RestaurantTags");
            //        m.MapLeftKey("RestaurantId");
            //        m.MapRightKey("TagId");
            //    });

            // one-to-one (one restaurant => one menu)
            //HasRequired(r => r.Menu)
            //    .WithRequiredPrincipal(m => m.Restaurant);

        }
    }
}
