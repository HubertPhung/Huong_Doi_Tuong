using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSieuThi
{
    internal class LoaiHang
    {
        public string MaSoLH;
        public string TenLH;
        public List <MatHang> DanhSachMH;
        
        public LoaiHang() { }
        public LoaiHang(string maSoLH, string tenLH, List<MatHang> danhSachMH)
        {
            MaSoLH = maSoLH;
            TenLH = tenLH;
            DanhSachMH = danhSachMH;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma so loai hang: " + MaSoLH);
            Console.WriteLine("Ten loai hang: " + TenLH);
            foreach (MatHang mH in DanhSachMH) {
                Console.WriteLine("Ten mat hang: " + mH.TenMH);
            }
        }
    }
}
