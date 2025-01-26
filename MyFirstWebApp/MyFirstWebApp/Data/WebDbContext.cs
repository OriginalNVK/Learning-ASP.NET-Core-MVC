using Microsoft.EntityFrameworkCore;

namespace MyFirstWebApp.Data
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options) { }

        public DbSet<HangHoa> HangHoas { get; set; }

        public DbSet<Loai> Loais { get; set; }

        public DbSet<DonHang> DonHangs { get; set; }

        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }

        public DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(e =>
            {
                e.ToTable("DonHang");
                e.HasKey(dh => dh.MaDh);
                e.Property(dh => dh.NgayDat).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.NguoiNhan).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<DonHangChiTiet>(e =>
            {
                e.ToTable("DonHangChiTiet");
                e.HasKey(dh => new { dh.MaDh, dh.MaHh });
                e.HasOne(e => e.DonHang)
                .WithMany(e => e.DonHangChiTiets)
                .HasForeignKey(e => e.MaDh)
                .HasConstraintName("FK_DH_DHCT");

                e.HasOne(e => e.HangHoa)
                .WithMany(e => e.DonHangChiTiets)
                .HasForeignKey(e => e.MaHh)
                .HasConstraintName("FK_HH_DHCT");
            });

            modelBuilder.Entity<NguoiDung>(e =>
            {
                e.ToTable("NguoiDung");
                e.HasIndex(x => x.UserName).IsUnique();
            });
        }
    }
}
