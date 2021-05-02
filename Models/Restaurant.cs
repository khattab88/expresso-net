using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public string Image { get; set; }
        public byte DeliveryTime { get; set; }
        public decimal DeliveryFee { get; set; }
        public bool SpecialOffres { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Category")]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual Menu Menu { get; set; }

        public Restaurant()
        {
            Tags = new HashSet<Tag>();
        }
    }
}
