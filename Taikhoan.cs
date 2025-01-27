﻿using System;
using System.Collections.Generic;

namespace QuanLyTrungTamAnhNgu.Models;

public partial class Taikhoan
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public string? Loaiuser { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<Giangvien> Giangviens { get; set; } = new List<Giangvien>();

    public virtual ICollection<Hocvien> Hocviens { get; set; } = new List<Hocvien>();

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
