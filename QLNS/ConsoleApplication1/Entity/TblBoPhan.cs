namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblBoPhan")]
    public partial class TblBoPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblBoPhan()
        {
            TblPhongBans = new HashSet<TblPhongBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaBophan { get; set; }

        [StringLength(50)]
        public string TenBoPhan { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblPhongBan> TblPhongBans { get; set; }
    }
}
