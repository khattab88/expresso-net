using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public UserRole Role { get; set; }

        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

        public DateTime PasswordChangedAt { get; set; }
        public string PasswordResetToken { get; set; }
        public DateTime PasswordResetExpiresAt { get; set; }

        public string Mobile { get; set; }
        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
    }
}
