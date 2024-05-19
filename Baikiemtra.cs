using System;
using System.Collections.Generic;

namespace QuanLyTrungTamAnhNgu.Models;

public partial class Baikiemtra
{
    public int Mabaikt { get; set; }

    public int Magv { get; set; }

    public int Mahv { get; set; }

    public string? Tenbaikt { get; set; }

    public DateOnly? Ngaykt { get; set; }

    public TimeOnly? Tgbatdau { get; set; }

    public TimeOnly? Tgketthuc { get; set; }

    public double? Ketqua { get; set; }

    public string? Danhgia { get; set; }

    public virtual Giangvien MagvNavigation { get; set; } = null!;

    public virtual Hocvien MahvNavigation { get; set; } = null!;
}
