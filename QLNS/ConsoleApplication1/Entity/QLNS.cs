namespace ConsoleApplication1.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLNS : DbContext
    {
        public QLNS()
            : base("name=QLNS")
        {
        }

        public virtual DbSet<TblBoPhan> TblBoPhans { get; set; }
        public virtual DbSet<TblPhongBan> TblPhongBans { get; set; }
        public virtual DbSet<TblTTCaNhan> TblTTCaNhans { get; set; }
        public virtual DbSet<TblTTNVCoBan> TblTTNVCoBans { get; set; }
        public virtual DbSet<tbuser> tbusers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBoPhan>()
                .Property(e => e.MaBophan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblBoPhan>()
                .HasMany(e => e.TblPhongBans)
                .WithRequired(e => e.TblBoPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TblPhongBan>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblPhongBan>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTCaNhan>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTCaNhan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTCaNhan>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.CMTND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.Anh)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
