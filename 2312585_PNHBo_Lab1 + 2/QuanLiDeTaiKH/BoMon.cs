using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class BoMon
    {
        public string TenBoMon ;
        public string PhongLamViec ;
        public string DienThoai ;
        public GiangVien TruongBoMon ;
        public DateTime NgayNhanChuc ;
        public List<GiangVien> DanhSachGiangVien ;

        public BoMon() { }

        public BoMon(string tenBoMon, string phongLamViec, string dienThoai, GiangVien truongBoMon, DateTime ngayNhanChuc)
        {
            TenBoMon = tenBoMon;
            PhongLamViec = phongLamViec;
            DienThoai = dienThoai;
            TruongBoMon = truongBoMon;
            NgayNhanChuc = ngayNhanChuc;
            DanhSachGiangVien = new List<GiangVien>();
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ten bo mon: {TenBoMon}");
            Console.WriteLine($"Phong lam viec: {PhongLamViec}");
            Console.WriteLine($"Dien thoai: {DienThoai}");
            Console.WriteLine($"Truong bo mon: {TruongBoMon.HoTen}");
            Console.WriteLine($"Ngay nhan chuc: {NgayNhanChuc.ToShortDateString()}");
            Console.WriteLine("Danh sach giang vien:");
            foreach (var gv in DanhSachGiangVien)
            {
                Console.WriteLine($"- {gv.HoTen}");
            }
        }


    }
}
