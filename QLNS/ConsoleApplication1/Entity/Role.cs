namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        public int ID { get; set; }

        [Column("Role")]
        [StringLength(50)]
        public string Role1 { get; set; }

        [StringLength(50)]
        public string MaRole { get; set; }

        [StringLength(50)]
        public string TenQuyen { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}
