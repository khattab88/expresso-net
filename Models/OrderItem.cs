using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public int Quantity { get; set; }
        public string Notes { get; set; }

        [Display(Name = "Order")]
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }


        [Display(Name = "MenuItem")]
        public Guid MenuItemId { get; set; }
        public virtual MenuItem MenuItem { get; set; }

        public virtual ICollection<OrderItemOption> Options { get; set; }

        public OrderItem()
        {
            Options = new HashSet<OrderItemOption>();
        }
    }
}
