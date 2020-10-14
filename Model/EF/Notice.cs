namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notice")]
    public partial class Notice
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Required]
        [StringLength(200)]
        public string title { get; set; }

        [Required]
        [StringLength(150)]
        public string metaTitle { get; set; }

        [Required]
        [StringLength(500)]
        public string description { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string content { get; set; }

        [StringLength(150)]
        public string images { get; set; }

        [StringLength(150)]
        public string attachFile { get; set; }

        public DateTime? createdDate { get; set; }

        [StringLength(100)]
        public string createdBy { get; set; }

        public DateTime? modifyDate { get; set; }

        [StringLength(100)]
        public string modifyBy { get; set; }

        public int? newView { get; set; }

        public int? categoryId { get; set; }

        public virtual CategoryNew CategoryNew { get; set; }
    }
}
