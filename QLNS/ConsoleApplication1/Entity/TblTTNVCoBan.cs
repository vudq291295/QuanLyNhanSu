namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTTNVCoBan")]
    public partial class TblTTNVCoBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblTTNVCoBan()
        {
            TblTTCaNhans = new HashSet<TblTTCaNhan>();
        }

        [Required]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(30)]
        public string HoTen { get; set; }

        [StringLength(30)]
        public string BiDanh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string TTHonNhan { get; set; }

        [StringLength(12)]
        public string CMTND { get; set; }

        public DateTime? NgayCap { get; set; }

        [StringLength(50)]
        public string NoiCap { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(50)]
        public string ChucDanh { get; set; }

        [StringLength(50)]
        public string LoaiHD { get; set; }

        [StringLength(10)]
        public string ThoiGian { get; set; }

        public DateTime? NgayKy { get; set; }

        public DateTime? NgayHetHan { get; set; }

        [StringLength(100)]
        public string Anh { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTTCaNhan> TblTTCaNhans { get; set; }
    }
}
