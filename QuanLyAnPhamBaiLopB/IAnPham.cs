﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPhamBaiLopB
{
    public interface IAnPham
    {
        float GiaTien { get; }
        string NhaXuatBan { get; }
        string Ten {  get; }

    }
}
