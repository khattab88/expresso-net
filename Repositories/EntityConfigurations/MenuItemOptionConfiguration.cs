using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class MenuItemOptionConfiguration : EntityTypeConfiguration<MenuItemOption>
    {
        public MenuItemOptionConfiguration()
        {
            Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
