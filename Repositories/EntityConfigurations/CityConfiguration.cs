using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            // 1. Table overrides
            // ToTable("tbl_courses")


            // 2. Primary Key
            // HasKey(c => c.Id);


            // 3. Properties
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Slug)
                .IsRequired()
                .HasMaxLength(50);


            // 4. Relations

            // one-to-many (one country => many cities)
            //HasRequired(ci => ci.Country)
            //    .WithMany(co => co.Cities)
            //    .HasForeignKey(ci => ci.CountryId)
            //    .WillCascadeOnDelete(true);
        }
    }
}
