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
    public class MenuItemOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public OptionType Type { get; set; }

        [Display(Name = "MenuItem")]
        public Guid MenuItemId { get; set; }
        public virtual MenuItem MenuItem { get; set; }

        public virtual ICollection<MenuItemOptionItem> OptionItems { get; set; }

        public MenuItemOption()
        {
            OptionItems = new HashSet<MenuItemOptionItem>();
        }
    }
}
