using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class GiangVien
    {
        public string HoTen;
        public DiaChi DiaChi;
        public List<string> DienThoai;
        public DateTime NgaySinh;
        public double Luong;
        public string Phai;
        public BoMon BoMon;

        public GiangVien(string hoTen, DiaChi diaChi, List<string> dienThoai, DateTime ngaySinh, double luong, string phai, BoMon boMon)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            NgaySinh = ngaySinh;
            Luong = luong;
            Phai = phai;
            BoMon = boMon;
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            DiaChi.XuatThongTin();
            Console.WriteLine($"Ngay sinh: {NgaySinh.ToShortDateString()}");
            Console.WriteLine($"Luong: {Luong}");
            Console.WriteLine($"Phai: {Phai}");
            Console.WriteLine($"Thuoc bo mon: {BoMon.TenBoMon}");
        }
    }
}
