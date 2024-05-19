using System;
using System.Collections.Generic;

namespace QuanLyTrungTamAnhNgu.Models;

public partial class Baitap
{
    public int Mabt { get; set; }

    public int Magv { get; set; }

    public int Mahv { get; set; }

    public string? Tenbt { get; set; }

    public DateTime? Tgbatdau { get; set; }

    public DateTime? Tgketthuc { get; set; }

    public double? Ketqua { get; set; }

    public string? Danhgia { get; set; }

    public virtual Giangvien MagvNavigation { get; set; } = null!;

    public virtual Hocvien MahvNavigation { get; set; } = null!;
}
