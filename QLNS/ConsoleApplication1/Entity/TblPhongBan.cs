namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblPhongBan")]
    public partial class TblPhongBan
    {
        [Required]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public DateTime? NgayTLap { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual TblBoPhan TblBoPhan { get; set; }
    }
}
