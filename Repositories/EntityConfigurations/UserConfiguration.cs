using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            //Property(u => u.Email)
            //    .IsRequired()
            //    .HasMaxLength(255);

            //Property(u => u.Password)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //Property(u => u.PasswordConfirm)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //Property(u => u.PasswordResetToken)
            //    .HasMaxLength(500);

            Property(u => u.Mobile)
                .HasMaxLength(50);
        }
    }
}
