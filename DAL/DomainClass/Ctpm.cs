using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[PrimaryKey("MaPhieu", "MaSach")]
[Table("CTPM")]
public partial class Ctpm
{
    [Key]
    [StringLength(7)]
    public string MaPhieu { get; set; } = null!;

    [Key]
    [StringLength(7)]
    public string MaSach { get; set; } = null!;

    public int? SoLuong { get; set; }

    [ForeignKey("MaPhieu")]
    [InverseProperty("Ctpms")]
    public virtual Phieumuon MaPhieuNavigation { get; set; } = null!;

    [ForeignKey("MaSach")]
    [InverseProperty("Ctpms")]
    public virtual Sach MaSachNavigation { get; set; } = null!;
}
