using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDuAn
{
    internal class Phong
    {
        public string MaPhong;
        public string TenPhong;
        public NhanVien TruongPhong;
        public DateTime NgayNhanChuc;
        public List<string> DiaDiem;
        public List<DuAn> DanhSachDuAn;

        public Phong() { }

        public Phong(string maPhong, string tenPhong, NhanVien truongPhong, DateTime ngayNhanChuc, List<string> diaDiem, List<DuAn> danhSachDuAn)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            TruongPhong = truongPhong;
            NgayNhanChuc = ngayNhanChuc;
            DiaDiem = diaDiem;
            DanhSachDuAn = danhSachDuAn;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma Phong: " + MaPhong);
            Console.WriteLine("Ten Phong: " + TenPhong);
            Console.WriteLine("Truong Phong:");
            Console.WriteLine("  Ma Nhan Vien: " + TruongPhong.MaNV);
            Console.WriteLine("  Ho va Ten: " + TruongPhong.HoTen);
            Console.WriteLine("  Ngay Nhan Chuc: " + NgayNhanChuc.ToShortDateString());
            Console.WriteLine("Danh sach dia diem:");
            foreach (var diaDiem in DiaDiem)
            {
                Console.WriteLine("  " + diaDiem);
            }
            Console.WriteLine("Danh sach du an:");
            foreach (var duAn in DanhSachDuAn)
            {
                Console.WriteLine("  Ma Du An: " + duAn.MaDuAn);
                Console.WriteLine("    Ten Du An: " + duAn.TenDuAn);
            }
        }


    }
}
