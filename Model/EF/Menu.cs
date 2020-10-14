using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    [Table("Menu")]
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            SubMenus = new HashSet<SubMenu>();
        }
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string text { get; set; }

        [Required]
        [StringLength(100)]
        public string link { get; set; }

        [StringLength(100)]
        public string displayOrder { get; set; }

        
        public int typeMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubMenu> SubMenus { get; set; }
        
    }
}
