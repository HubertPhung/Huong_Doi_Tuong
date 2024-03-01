using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class CongViec
    {
        public string TenCongViec;
        public DateTime NgayBatDau;
        public DateTime NgayKetThuc;
        public List<GiangVien> DanhSachGiangVien;
        public double KetQuaThucHien;
        public double PhuCap;

        public CongViec(string tenCongViec, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            TenCongViec = tenCongViec;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            DanhSachGiangVien = new List<GiangVien>();
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ten cong viec: {TenCongViec}");
            Console.WriteLine($"Ngay bat dau: {NgayBatDau.ToShortDateString()}");
            Console.WriteLine($"Ngay ket thuc: {NgayKetThuc.ToShortDateString()}");
            Console.WriteLine($"Ket qua thuc hien: {KetQuaThucHien}");
            Console.WriteLine($"Phu cap: {PhuCap}");
            Console.WriteLine("Danh sach giang vien tham gia cong viec:");
            foreach (var gv in DanhSachGiangVien)
            {
                Console.WriteLine($"- {gv.HoTen}");
            }
        }
    }
}
