using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public decimal SubTotal { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal Total { get; set; }

        public bool Paid { get; set; }
        public bool Delivered { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        [Display(Name = "Branch")]
        public Guid BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        [Display(Name = "Address")]
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }
    }
}
