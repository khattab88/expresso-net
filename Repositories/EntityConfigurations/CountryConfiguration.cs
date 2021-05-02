using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
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

            Property(c => c.Alias)
                .IsRequired()
                .HasMaxLength(10);

            Property(c => c.Currency)
                .IsRequired()
                .HasMaxLength(10);


            // 4. Relations

        }
    }
}
