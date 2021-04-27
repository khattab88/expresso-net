using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuItemOptionItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public double Value { get; set; }

        [Display(Name = "MenuItemOption")]
        public Guid MenuItemOptionId { get; set; }
        public virtual MenuItemOption MenuItemOption { get; set; }
    }
}
