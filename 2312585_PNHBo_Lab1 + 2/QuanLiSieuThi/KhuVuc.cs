using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSieuThi
{
    internal class KhuVuc
    {
        public string MaSoKV;
        public string TenKV;
        public LoaiHang LH;

        public KhuVuc() { }
        public KhuVuc(string maSoKV, string tenKV, LoaiHang lH)
        {
            MaSoKV = maSoKV;
            TenKV = tenKV;
            LH = lH;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma so khu vuc: " + MaSoKV);
            Console.WriteLine("Ten khu vuc: " + TenKV);
            Console.WriteLine("Loai hang: " + LH.TenLH);
        }
    }
}
