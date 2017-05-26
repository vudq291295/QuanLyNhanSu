namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string MaNhanVien { get; set; }

        [StringLength(100)]
        public string TenNhanVien { get; set; }

        public int? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(500)]
        public string QueQuan { get; set; }

        [StringLength(50)]
        public string PhongBanID { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
