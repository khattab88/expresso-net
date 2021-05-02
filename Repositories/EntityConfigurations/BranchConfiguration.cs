using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(b => b.Slug)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
