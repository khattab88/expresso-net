using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter a tag name!")]
        public string Name { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }

        public Tag()
        {
            Restaurants = new HashSet<Restaurant>();
        }
    }
}
