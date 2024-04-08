using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("PHIEUMUON")]
public partial class Phieumuon
{
    [Key]
    [StringLength(7)]
    public string MaPhieu { get; set; } = null!;

    [Column("MaNV")]
    [StringLength(7)]
    public string? MaNv { get; set; }

    [StringLength(7)]
    public string? MaDocGia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayMuon { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayHetHan { get; set; }

    [StringLength(50)]
    public string? TrangThaiTra { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTra { get; set; }

    [StringLength(50)]
    public string? GhiChu { get; set; }

    [InverseProperty("MaPhieuNavigation")]
    public virtual ICollection<Ctpm> Ctpms { get; set; } = new List<Ctpm>();

    [ForeignKey("MaDocGia")]
    [InverseProperty("Phieumuons")]
    public virtual Docgium? MaDocGiaNavigation { get; set; }

    [ForeignKey("MaNv")]
    [InverseProperty("Phieumuons")]
    public virtual Taikhoan? MaNvNavigation { get; set; }
}
