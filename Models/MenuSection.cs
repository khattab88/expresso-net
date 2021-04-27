using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuSection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Menu")]
        public Guid MenuId { get; set; }
        public virtual Menu Menu { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }

        public MenuSection()
        {
            MenuItems = new HashSet<MenuItem>();
        }
    }
}
