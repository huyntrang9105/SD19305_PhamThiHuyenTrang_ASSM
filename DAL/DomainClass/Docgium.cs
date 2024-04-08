using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("DOCGIA")]
public partial class Docgium
{
    [Key]
    [StringLength(7)]
    public string MaDocGia { get; set; } = null!;

    [StringLength(50)]
    public string? TenDocGia { get; set; }

    [Column("SDT")]
    public int? Sdt { get; set; }

    [InverseProperty("MaDocGiaNavigation")]
    public virtual ICollection<Phieumuon> Phieumuons { get; set; } = new List<Phieumuon>();
}
