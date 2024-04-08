using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ctpm> Ctpms { get; set; }

    public virtual DbSet<Docgium> Docgia { get; set; }

    public virtual DbSet<Phieumuon> Phieumuons { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Theloai> Theloais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= TRANGPTH\\TRANG ;Initial Catalog= ASSM_NET1021_QLSACH ;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ctpm>(entity =>
        {
            entity.HasKey(e => new { e.MaPhieu, e.MaSach }).HasName("PK__CTPM__ED43E8A2D5E0D48D");

            entity.Property(e => e.MaPhieu).IsFixedLength();
            entity.Property(e => e.MaSach).IsFixedLength();

            entity.HasOne(d => d.MaPhieuNavigation).WithMany(p => p.Ctpms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTPM__MaPhieu__44FF419A");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.Ctpms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTPM__MaSach__440B1D61");
        });

        modelBuilder.Entity<Docgium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DOCGIA__F165F945D2A267CC");

            entity.Property(e => e.MaDocGia).IsFixedLength();
        });

        modelBuilder.Entity<Phieumuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieu).HasName("PK__PHIEUMUO__2660BFE0A67DBEF7");

            entity.Property(e => e.MaPhieu).IsFixedLength();
            entity.Property(e => e.MaDocGia).IsFixedLength();
            entity.Property(e => e.MaNv).IsFixedLength();

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.Phieumuons).HasConstraintName("FK__PHIEUMUON__MaDoc__412EB0B6");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Phieumuons).HasConstraintName("FK__PHIEUMUON__MaNV__403A8C7D");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__SACH__B235742D00048CFA");

            entity.Property(e => e.MaSach).IsFixedLength();

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Saches).HasConstraintName("FK__SACH__MaTheLoai__3D5E1FD2");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__TAIKHOAN__2725D70ACA3F4B18");

            entity.Property(e => e.MaNv).IsFixedLength();
        });

        modelBuilder.Entity<Theloai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__THELOAI__D73FF34ACF2B523B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
