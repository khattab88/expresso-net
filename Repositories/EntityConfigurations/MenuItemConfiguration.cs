using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class MenuItemConfiguration : EntityTypeConfiguration<MenuItem>
    {
        public MenuItemConfiguration()
        {
            Property(mi => mi.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(mi => mi.Description)
                .HasMaxLength(500);
        }
    }
}
