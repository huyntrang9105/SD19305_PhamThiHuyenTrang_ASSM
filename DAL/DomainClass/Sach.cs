using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("SACH")]
public partial class Sach
{
    [Key]
    [StringLength(7)]
    public string MaSach { get; set; } = null!;

    [StringLength(50)]
    public string? TenSach { get; set; }

    [StringLength(50)]
    public string? MaTheLoai { get; set; }

    [Column("NXB")]
    [StringLength(50)]
    public string? Nxb { get; set; }

    [Column("NamXB", TypeName = "datetime")]
    public DateTime? NamXb { get; set; }

    [InverseProperty("MaSachNavigation")]
    public virtual ICollection<Ctpm> Ctpms { get; set; } = new List<Ctpm>();

    [ForeignKey("MaTheLoai")]
    [InverseProperty("Saches")]
    public virtual Theloai? MaTheLoaiNavigation { get; set; }
}
