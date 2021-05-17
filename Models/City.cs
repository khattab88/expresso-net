using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter a city name!")]
        public string Name { get; set; }
        public string Slug { get; set; }

        [Display(Name = "Country")]
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Area> Areas { get; set; }

        public City()
        {
            Areas = new HashSet<Area>();
        }
    }
}
