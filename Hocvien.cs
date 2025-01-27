﻿using System;
using System.Collections.Generic;

namespace QuanLyTrungTamAnhNgu.Models;

public partial class Hocvien
{
    public int Mahv { get; set; }

    public string? Username { get; set; }

    public string? Tenhv { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? Gioitinh { get; set; }

    public string? Diachi { get; set; }

    public string? Socccd { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Baikiemtra> Baikiemtras { get; set; } = new List<Baikiemtra>();

    public virtual ICollection<Baitap> Baitaps { get; set; } = new List<Baitap>();

    public virtual ICollection<Lichhoc> Lichhocs { get; set; } = new List<Lichhoc>();

    public virtual ICollection<Phieudangkikhoahoc> Phieudangkikhoahocs { get; set; } = new List<Phieudangkikhoahoc>();

    public virtual ICollection<Phieuthuhocphi> Phieuthuhocphis { get; set; } = new List<Phieuthuhocphi>();

    public virtual Taikhoan? UsernameNavigation { get; set; }
}
