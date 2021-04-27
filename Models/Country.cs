using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        public string Currency { get; set; }
        public virtual ICollection<City> Cities { get; set; }

        public Country()
        {
            Cities = new HashSet<City>();
        }
    }
}
