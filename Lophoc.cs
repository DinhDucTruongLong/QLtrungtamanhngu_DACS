﻿using System;
using System.Collections.Generic;

namespace QuanLyTrungTamAnhNgu.Models;

public partial class Lophoc
{
    public int Malop { get; set; }

    public int Makh { get; set; }

    public string? Tenlop { get; set; }

    public DateTime? Tgtao { get; set; }

    public DateOnly? Ngaynhaphoc { get; set; }

    public DateOnly? Ngayketthuc { get; set; }

    public virtual ICollection<Lichday> Lichdays { get; set; } = new List<Lichday>();

    public virtual ICollection<Lichhoc> Lichhocs { get; set; } = new List<Lichhoc>();

    public virtual Khoahoc MakhNavigation { get; set; } = null!;
}
