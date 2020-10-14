using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    [Table("SubMenu")]
    public partial class SubMenu
    {
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string text { get; set; }

        [Required]
        [StringLength(100)]
        public string link { get; set; }

        [StringLength(100)]
        public string displayOrder { get; set; }

        [ForeignKey("Menu")]
        public int typeMenu { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
