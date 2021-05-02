using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(500);

            Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Building)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Floor)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Apartment)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Mobile)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Instructions)
                .HasMaxLength(500);

        }
    }
}
