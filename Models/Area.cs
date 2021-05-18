using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter area name!")]
        public string Name { get; set; }
        public string Slug { get; set; }

        [Display(Name = "City")]
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
    }
}
