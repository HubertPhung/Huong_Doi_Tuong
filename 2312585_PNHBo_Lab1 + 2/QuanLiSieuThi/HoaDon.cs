using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSieuThi
{
    internal class HoaDon
    {

        public string SoHD;
        public DateTime NgayLap;
        public NhanVien NV;
        public string TenKH;
        public string DiaChi;
        public List<MatHang> DSMatHang;
        public float DonGia;
        public float ThanhTien;
        public float TongTien;

        public HoaDon() { }
        public HoaDon (string soHD, DateTime ngayLap, NhanVien nV, string tenKH, string diaChi, List<MatHang> dSMatHang, float donGia, float thanhTien, float tongTien)
        {
            SoHD = soHD;
            NgayLap = ngayLap;
            NV = nV;
            TenKH = tenKH;
            DiaChi = diaChi;
            DSMatHang = dSMatHang;
            DonGia = donGia;
            ThanhTien = thanhTien;
            TongTien = tongTien;
        }

        public void Xuat()
        {
            Console.WriteLine("So hoa don: " + SoHD);
            Console.WriteLine("Ngay lap: " + NgayLap.ToShortDateString());
            Console.WriteLine("Nhan vien lap: " + NV.TenNV);
            Console.WriteLine("Ten khach hang: " + TenKH);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Danh sach mat hang:");
            foreach (var matHang in DSMatHang)
            {
                Console.WriteLine("- " + matHang.TenMH);
            }
            Console.WriteLine("Don gia: " + DonGia);
            Console.WriteLine("Thanh tien: " + ThanhTien);
            Console.WriteLine("Tong tien: " + TongTien);
        }
    }
}
