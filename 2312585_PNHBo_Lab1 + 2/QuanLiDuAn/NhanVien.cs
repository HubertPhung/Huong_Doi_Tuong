using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDuAn
{
    internal class NhanVien
    {
        public string MaNV;
        public string HoTen;
        public string DiaChi;
        public double Luong;
        public string GioiTinh;
        public DateTime NgaySinh;
        public Phong PhongLamViec;
        public List<DuAn> DuAnThamGia;
        public NhanVien NguoiQuanLy;
        public List<ThanNhan> DanhSachThanNhan;

        public NhanVien() { }


        public NhanVien(string maNV, string hoTen) {
            MaNV = maNV;
            HoTen = hoTen;
        }

        public NhanVien(string maNV, string hoTen, string diaChi, double luong, string gioiTinh, DateTime ngaySinh, Phong phongLamViec, List<DuAn> duAnThamGia, NhanVien nguoiQuanLy, List<ThanNhan> danhSachThanNhan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            DiaChi = diaChi;
            Luong = luong;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            PhongLamViec = phongLamViec;
            DuAnThamGia = duAnThamGia;
            NguoiQuanLy = nguoiQuanLy;
            DanhSachThanNhan = danhSachThanNhan;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma Nhan Vien: " + MaNV);
            Console.WriteLine("Ho va Ten: " + HoTen);
            Console.WriteLine("Dia Chi: " + DiaChi);
            Console.WriteLine("Luong: " + Luong);
            Console.WriteLine("Gioi Tinh: " + GioiTinh);
            Console.WriteLine("Ngay Sinh: " + NgaySinh.ToShortDateString());
            Console.WriteLine("Phong Lam Viec:");
            Console.WriteLine("  Ma Phong: " + PhongLamViec.MaPhong);
            Console.WriteLine("  Ten Phong: " + PhongLamViec.TenPhong);
            Console.WriteLine("Du An Tham Gia:");
            foreach (var duAn in DuAnThamGia)
            {
                Console.WriteLine("  Ma Du An: " + duAn.MaDuAn);
                Console.WriteLine("    Ten Du An: " + duAn.TenDuAn);
            }
            Console.WriteLine("Nguoi Quan Ly:");
            if (NguoiQuanLy != null)
            {
                Console.WriteLine("  Ma Nhan Vien: " + NguoiQuanLy.MaNV);
                Console.WriteLine("    Ho va Ten: " + NguoiQuanLy.HoTen);
            }
            else
            {
                Console.WriteLine("  Khong co");
            }
            Console.WriteLine("Danh Sach Than Nhan:");
            foreach (var thanNhan in DanhSachThanNhan)
            {
                Console.WriteLine("  Ho va Ten: " + thanNhan.HoTen);
                Console.WriteLine("    Gioi Tinh: " + thanNhan.GioiTinh);
                Console.WriteLine("    Ngay Sinh: " + thanNhan.NgaySinh.ToShortDateString());
                Console.WriteLine("    Moi Quan He: " + thanNhan.MoiQuanHe);
            }
        }
    }
}
