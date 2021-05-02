using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class MenuSectionConfiguration : EntityTypeConfiguration<MenuSection>
    {
        public MenuSectionConfiguration()
        {
            Property(ms => ms.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
