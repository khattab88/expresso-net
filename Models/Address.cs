using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public string Mobile { get; set; }
        public string Instructions { get; set; }

        [Display(Name = "User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        [Display(Name = "Area")]
        public Guid AreaId { get; set; }
        public virtual Area Area { get; set; }
    }
}
