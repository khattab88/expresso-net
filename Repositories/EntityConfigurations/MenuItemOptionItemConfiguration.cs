using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class MenuItemOptionItemConfiguration : EntityTypeConfiguration<MenuItemOptionItem>
    {
        public MenuItemOptionItemConfiguration()
        {
            Property(oi => oi.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
