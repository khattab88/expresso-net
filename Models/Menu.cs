using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Menu
    {
        [ForeignKey("Restaurant")]
        public Guid Id { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<MenuSection> MenuSections { get; set; }

        public Menu()
        {
            MenuSections = new HashSet<MenuSection>();
        }
    }
}
