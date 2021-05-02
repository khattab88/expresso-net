using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class AreaConfiguration : EntityTypeConfiguration<Area>
    {
        public AreaConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Slug)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
