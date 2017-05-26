namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTTCaNhan")]
    public partial class TblTTCaNhan
    {
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string NoiSinh { get; set; }

        [StringLength(50)]
        public string NguyenQuan { get; set; }

        [StringLength(100)]
        public string DCThuongChu { get; set; }

        [StringLength(100)]
        public string DCTamChu { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string DanToc { get; set; }

        [StringLength(20)]
        public string TonGiao { get; set; }

        [StringLength(20)]
        public string QuocTich { get; set; }

        [StringLength(50)]
        public string TiengNN { get; set; }

        [StringLength(50)]
        public string TrinhDoNN { get; set; }

        [StringLength(30)]
        public string HocVan { get; set; }

        [StringLength(30)]
        public string HocHam { get; set; }

        public DateTime? NgayVaoDoan { get; set; }

        [StringLength(50)]
        public string TenDoanThe { get; set; }

        [StringLength(50)]
        public string ChucVuDoan { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [StringLength(10)]
        public string id { get; set; }

        public virtual TblTTNVCoBan TblTTNVCoBan { get; set; }
    }
}
