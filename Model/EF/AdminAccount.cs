namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminAccount")]
    public partial class AdminAccount
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        public bool? status { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(10)]
        public string phoneNumber { get; set; }

        [StringLength(100)]
        public string email { get; set; }
    }
}
