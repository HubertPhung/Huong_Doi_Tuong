using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDuAn
{
    internal class DuAn
    {
        public string MaDuAn;
        public string TenDuAn;
        public string DiaDiemThucHien;
        public Phong PhongQuanLy;
        public Dictionary<NhanVien, int> NhanVienLamViec;

        public DuAn() { }

        public DuAn(string maDuAn, string tenDuAn, string diaDiem, Phong phongQuanLy, Dictionary<NhanVien, int> nhanVienLamViec)
        {
            MaDuAn = maDuAn;
            TenDuAn = tenDuAn;
            DiaDiemThucHien = diaDiem;
            PhongQuanLy = phongQuanLy;
            NhanVienLamViec = nhanVienLamViec;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma Du An: " + MaDuAn);
            Console.WriteLine("Ten Du An: " + TenDuAn);
            Console.WriteLine("Dia Diem Thuc Hien: " + DiaDiemThucHien);
            Console.WriteLine("Phong Quan Ly:");
            Console.WriteLine("  - Ma Phong: " + PhongQuanLy.MaPhong);
            Console.WriteLine("  - Ten Phong: " + PhongQuanLy.TenPhong);
            Console.WriteLine("Danh sach nhan vien lam viec:");
            foreach (var pair in NhanVienLamViec)
            {
                Console.WriteLine("  - Ma Nhan Vien: " + pair.Key.MaNV);
                Console.WriteLine("    So Gio Lam Viec: " + pair.Value);
            }
        }
    }
}
