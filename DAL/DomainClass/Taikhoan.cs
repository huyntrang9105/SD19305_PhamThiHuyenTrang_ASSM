using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("TAIKHOAN")]
public partial class Taikhoan
{
    [Key]
    [Column("MaNV")]
    [StringLength(7)]
    public string MaNv { get; set; } = null!;

    [StringLength(50)]
    public string? HoTen { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgaySinh { get; set; }

    [Column("SDT")]
    public int? Sdt { get; set; }

    [StringLength(50)]
    public string? VaiTro { get; set; }

    [Column("TaiKhoan")]
    [StringLength(50)]
    public string? TaiKhoan1 { get; set; }

    [StringLength(50)]
    public string? MatKhau { get; set; }

    [InverseProperty("MaNvNavigation")]
    public virtual ICollection<Phieumuon> Phieumuons { get; set; } = new List<Phieumuon>();
}
