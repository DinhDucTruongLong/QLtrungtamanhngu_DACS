using System;
using System.Collections.Generic;

namespace QuanLyTrungTamAnhNgu.Models;

public partial class Lichday
{
    public int Mald { get; set; }

    public int Malop { get; set; }

    public int Magv { get; set; }

    public string? Tuan { get; set; }

    public string? Caday { get; set; }

    public DateOnly? Ngayday { get; set; }

    public string? Ghichu { get; set; }

    public virtual Giangvien MagvNavigation { get; set; } = null!;

    public virtual Lophoc MalopNavigation { get; set; } = null!;
}
