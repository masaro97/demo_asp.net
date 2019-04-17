namespace Models.FW
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLySinhVien : DbContext
    {
        public QuanLySinhVien()
            : base("name=QuanLySinhVien")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<DIEM> DIEMs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Taikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MAMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.TENLOP)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MAMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.TENMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.HO)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.TEN)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.PHAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.NOISINH)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.DIACHI)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);
        }
    }
}
