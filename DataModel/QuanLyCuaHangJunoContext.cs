using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class QuanLyCuaHangJunoContext : DbContext
    {
        public QuanLyCuaHangJunoContext()
        {
        }

        public QuanLyCuaHangJunoContext(DbContextOptions<QuanLyCuaHangJunoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatHangSanPham> DatHangSanPhams { get; set; }
        public virtual DbSet<GiamGiaHoaDon> GiamGiaHoaDons { get; set; }
        public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public virtual DbSet<HoaDonBanHangSanPham> HoaDonBanHangSanPhams { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<KhuyenMaiSanPham> KhuyenMaiSanPhams { get; set; }
        public virtual DbSet<KichCo> KichCos { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<Mau> Maus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhapHangSanPham> NhapHangSanPhams { get; set; }
        public virtual DbSet<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
        public virtual DbSet<PhieuDatHang> PhieuDatHangs { get; set; }
        public virtual DbSet<PhieuDoiHang> PhieuDoiHangs { get; set; }
        public virtual DbSet<PhieuDoiSanPhamDoi> PhieuDoiSanPhamDois { get; set; }
        public virtual DbSet<PhieuDoiSanPhamHd> PhieuDoiSanPhamHds { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<PhieuTraHang> PhieuTraHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-94IFOHB\\SQLEXPRESS;Initial CataLog=QuanLyCuaHangJuno;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DatHangSanPham>(entity =>
            {
                entity.HasKey(e => new { e.MaPhieuDat, e.MaSpCt })
                    .HasName("PK__DatHang___23AD866EF1D58CE1");

                entity.ToTable("DatHang_SanPham");

                entity.Property(e => e.MaPhieuDat)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaSpCt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP_CT");

                entity.HasOne(d => d.MaPhieuDatNavigation)
                    .WithMany(p => p.DatHangSanPhams)
                    .HasForeignKey(d => d.MaPhieuDat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuDatHang");

                entity.HasOne(d => d.MaSpCtNavigation)
                    .WithMany(p => p.DatHangSanPhams)
                    .HasForeignKey(d => d.MaSpCt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dh_sp_SanPham_ChiTiet");
            });

            modelBuilder.Entity<GiamGiaHoaDon>(entity =>
            {
                entity.HasKey(e => e.MaGg)
                    .HasName("PK__GiamGiaH__2725AE82E837B5D8");

                entity.ToTable("GiamGiaHoaDon");

                entity.Property(e => e.MaGg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaGG");

                entity.Property(e => e.DieuKienApDung).HasColumnType("money");

                entity.Property(e => e.TgbatDau)
                    .HasColumnType("datetime")
                    .HasColumnName("TGBatDau");

                entity.Property(e => e.TgketThuc)
                    .HasColumnType("datetime")
                    .HasColumnName("TGKetThuc");
            });

            modelBuilder.Entity<HoaDonBanHang>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDonBa__2725A6E05C662CDA");

                entity.ToTable("HoaDonBanHang");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaGg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaGG");

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgayBan).HasColumnType("datetime");

                entity.HasOne(d => d.MaGgNavigation)
                    .WithMany(p => p.HoaDonBanHangs)
                    .HasForeignKey(d => d.MaGg)
                    .HasConstraintName("fk_HoaDonBanHang_GiamGiaHoaDon");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDonBanHangs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HoaDonBanHang_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoaDonBanHangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HoaDonBanHang_NhanVien");
            });

            modelBuilder.Entity<HoaDonBanHangSanPham>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSpCt })
                    .HasName("PK__HoaDonBa__05622DA5311659C1");

                entity.ToTable("HoaDonBanHang_SanPham");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaSpCt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP_CT");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.HoaDonBanHangSanPhams)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HoaDonBanHang_SanPham_HoaDon");

                entity.HasOne(d => d.MaSpCtNavigation)
                    .WithMany(p => p.HoaDonBanHangSanPhams)
                    .HasForeignKey(d => d.MaSpCt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HoaDonBanHang_SanPham_ChiTiet");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E18C5445C");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HoTenKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("HoTenKH");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaKm)
                    .HasName("PK__KhuyenMa__2725CF15937AE90B");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.MaKm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKM");

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");
            });

            modelBuilder.Entity<KhuyenMaiSanPham>(entity =>
            {
                entity.HasKey(e => new { e.MaKm, e.MaSp })
                    .HasName("PK__KhuyenMa__F5579F943ADF1816");

                entity.ToTable("KhuyenMai_SanPham");

                entity.Property(e => e.MaKm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKM");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.HasOne(d => d.MaKmNavigation)
                    .WithMany(p => p.KhuyenMaiSanPhams)
                    .HasForeignKey(d => d.MaKm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KhuyenMai");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.KhuyenMaiSanPhams)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_km_sp_SanPham");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.MaKc)
                    .HasName("PK__KichCo__2725CF035AB801B8");

                entity.ToTable("KichCo");

                entity.Property(e => e.MaKc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKC");

                entity.Property(e => e.KichCo1)
                    .HasMaxLength(20)
                    .HasColumnName("KichCo");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSp)
                    .HasName("PK__LoaiSanP__1224CA7CC421F502");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.MaLoaiSp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaLoaiSP");

                entity.Property(e => e.TenLoaiSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenLoaiSP");
            });

            modelBuilder.Entity<Mau>(entity =>
            {
                entity.HasKey(e => e.MaMau)
                    .HasName("PK__Mau__3A5BBB7D9AA50F42");

                entity.ToTable("Mau");

                entity.Property(e => e.MaMau)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mau1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Mau");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70ABD0B82D1");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.Cmt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMT");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HoTenNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("HoTenNV");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Quyen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenTk)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TenTK");
            });

            modelBuilder.Entity<NhapHangSanPham>(entity =>
            {
                entity.HasKey(e => new { e.MaPhNhap, e.MaSpCt })
                    .HasName("PK__NhapHang__16A19ACC295DE4CC");

                entity.ToTable("NhapHang_SanPham");

                entity.Property(e => e.MaPhNhap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaSpCt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP_CT");

                entity.HasOne(d => d.MaPhNhapNavigation)
                    .WithMany(p => p.NhapHangSanPhams)
                    .HasForeignKey(d => d.MaPhNhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuNhapHang");

                entity.HasOne(d => d.MaSpCtNavigation)
                    .WithMany(p => p.NhapHangSanPhams)
                    .HasForeignKey(d => d.MaSpCt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nh_sp_SanPham_ChiTiet");
            });

            modelBuilder.Entity<PhieuBaoHanh>(entity =>
            {
                entity.HasKey(e => e.MaPhieu)
                    .HasName("PK__PhieuBao__2660BFE03359702E");

                entity.ToTable("PhieuBaoHanh");

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Loi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaSpCt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP_CT");

                entity.Property(e => e.NgayLapPhieu).HasColumnType("datetime");

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuBaoHanhs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuBaoHanh_NhanVien");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.PhieuBaoHanhs)
                    .HasForeignKey(d => new { d.MaHd, d.MaSpCt })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuBaoHanh_hoadonbanhang_sanpham");
            });

            modelBuilder.Entity<PhieuDatHang>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDat)
                    .HasName("PK__PhieuDat__01EA0D2BCB6D44B6");

                entity.ToTable("PhieuDatHang");

                entity.Property(e => e.MaPhieuDat)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.ThoiHanGiaoHang).HasColumnType("date");
            });

            modelBuilder.Entity<PhieuDoiHang>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDoi)
                    .HasName("PK__PhieuDoi__01EABA5B4B67C2C0");

                entity.ToTable("PhieuDoiHang");

                entity.Property(e => e.MaPhieuDoi)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LyDoDoi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgayLap).HasColumnType("datetime");

                entity.Property(e => e.TienThuLai).HasColumnType("money");

                entity.Property(e => e.TienThua).HasColumnType("money");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.PhieuDoiHangs)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuTraHangg_hoadonbanhang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuDoiHangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuTraHangg_NhanVien");
            });

            modelBuilder.Entity<PhieuDoiSanPhamDoi>(entity =>
            {
                entity.ToTable("PhieuDoi_SanPhamDoi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaPd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaPD");

                entity.Property(e => e.MaSpct)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSPCT");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.HasOne(d => d.MaPdNavigation)
                    .WithMany(p => p.PhieuDoiSanPhamDois)
                    .HasForeignKey(d => d.MaPd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MaPhieuDoi1");
            });

            modelBuilder.Entity<PhieuDoiSanPhamHd>(entity =>
            {
                entity.ToTable("PhieuDoi_SanPhamHD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaPd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaPD");

                entity.Property(e => e.MaSpct)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSPCT");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.HasOne(d => d.MaPdNavigation)
                    .WithMany(p => p.PhieuDoiSanPhamHds)
                    .HasForeignKey(d => d.MaPd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MaPhieuDoi");
            });

            modelBuilder.Entity<PhieuNhapHang>(entity =>
            {
                entity.HasKey(e => e.MaPhNhap)
                    .HasName("PK__PhieuNha__34E61189BFF798F4");

                entity.ToTable("PhieuNhapHang");

                entity.Property(e => e.MaPhNhap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaPhieuDat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.NguoiGiao)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuNhapHangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuNhapHang_NhanVien");

                entity.HasOne(d => d.MaPhieuDatNavigation)
                    .WithMany(p => p.PhieuNhapHangs)
                    .HasForeignKey(d => d.MaPhieuDat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuNhapHang_PhieuDatHang");
            });

            modelBuilder.Entity<PhieuTraHang>(entity =>
            {
                entity.HasKey(e => e.MaPhieuTra)
                    .HasName("PK__PhieuTra__1D880A46DD69A3CD");

                entity.ToTable("PhieuTraHang");

                entity.Property(e => e.MaPhieuTra)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LyDoTra)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaSpCt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP_CT");

                entity.Property(e => e.NgayLap).HasColumnType("datetime");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuTraHangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuTraHang_NhanVien");

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.PhieuTraHangs)
                    .HasForeignKey(d => new { d.MaHd, d.MaSpCt })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PhieuTraHang_hoadonbanhang_sanpham");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081C61CF59B5");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.ChatLieu).HasMaxLength(50);

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.KieuDang).HasMaxLength(50);

                entity.Property(e => e.MaLoaiSp)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaLoaiSP");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dk_SanPham_LoaiSP");
            });

            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaSpCt)
                    .HasName("PK__SanPham___2478B45315CC1954");

                entity.ToTable("SanPham_ChiTiet");

                entity.Property(e => e.MaSpCt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP_CT");

                entity.Property(e => e.MaKc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKC");

                entity.Property(e => e.MaMau)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaSp)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.HasOne(d => d.MaKcNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.MaKc)
                    .HasConstraintName("fk_sp_ct_kc");

                entity.HasOne(d => d.MaMauNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.MaMau)
                    .HasConstraintName("fk_sp_ct_mau");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sp_ct_SanPham");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
