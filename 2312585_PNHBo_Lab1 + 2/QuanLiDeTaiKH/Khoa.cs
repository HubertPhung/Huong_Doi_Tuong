using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class Khoa
    {
        public string TenKhoa;
        public int NamThanhLap;
        public string PhongLamViec;
        public string DienThoai;
        public GiangVien TruongKhoa;
        public DateTime NgayNhanChuc;
        public List<BoMon> DanhSachBoMon;

        public Khoa(string tenKhoa, int namThanhLap, string phongLamViec, string dienThoai, GiangVien truongKhoa, DateTime ngayNhanChuc)
        {
            TenKhoa = tenKhoa;
            NamThanhLap = namThanhLap;
            PhongLamViec = phongLamViec;
            DienThoai = dienThoai;
            TruongKhoa = truongKhoa;
            NgayNhanChuc = ngayNhanChuc;
            DanhSachBoMon = new List<BoMon>();
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ten khoa: {TenKhoa}");
            Console.WriteLine($"Nam thanh lap: {NamThanhLap}");
            Console.WriteLine($"Phong lam viec: {PhongLamViec}");
            Console.WriteLine($"Dien thoai: {DienThoai}");
            Console.WriteLine($"Truong khoa: {TruongKhoa.HoTen}");
            Console.WriteLine($"Ngay nhan chuc: {NgayNhanChuc.ToShortDateString()}");
            Console.WriteLine("Danh sach bo mon:");
            foreach (var bm in DanhSachBoMon)
            {
                Console.WriteLine($"- {bm.TenBoMon}");
            }
        }

    }
}
