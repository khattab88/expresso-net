using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderItemOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Display(Name = "OrderItem")]
        public Guid OrderItemId { get; set; }
        public virtual OrderItem OrderItem { get; set; }

        [Display(Name = "MenuItemOption")]
        public Guid MenuItemOptionId { get; set; }
        public virtual MenuItemOption MenuItemOption { get; set; }

        public virtual ICollection<MenuItemOptionItem> MenuItemOptionItems { get; set; }
    }
}
