using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        [Display(Name = "MenuSection")]
        public Guid MenuSectionId { get; set; }
        public virtual MenuSection MenuSection { get; set; }

        public virtual ICollection<MenuItemOption> Options { get; set; }

        public MenuItem()
        {
            Options = new HashSet<MenuItemOption>();
        }
    }
}
