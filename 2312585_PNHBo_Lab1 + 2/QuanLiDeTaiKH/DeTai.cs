using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class DeTai
    {
        public string TenDeTai;
        public string CapQuanLy;
        public double KinhPhi;
        public DateTime NgayBatDau;
        public DateTime NgayKetThuc;
        public ChuDe ChuDe;
        public List<CongViec> DanhSachCongViec;

        public DeTai(string tenDeTai, string capQuanLy, double kinhPhi, DateTime ngayBatDau, DateTime ngayKetThuc, ChuDe chuDe)
        {
            TenDeTai = tenDeTai;
            CapQuanLy = capQuanLy;
            KinhPhi = kinhPhi;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            ChuDe = chuDe;
            DanhSachCongViec = new List<CongViec>();
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ten de tai: {TenDeTai}");
            Console.WriteLine($"Cap quan ly: {CapQuanLy}");
            Console.WriteLine($"Kinh phi: {KinhPhi}");
            Console.WriteLine($"Ngay bat dau: {NgayBatDau.ToShortDateString()}");
            Console.WriteLine($"Ngay ket thuc: {NgayKetThuc.ToShortDateString()}");
            Console.WriteLine($"Thuoc chu de: {ChuDe.TenChuDe}");
            Console.WriteLine("Danh sach cong viec:");
            foreach (var cv in DanhSachCongViec)
            {
                Console.WriteLine($"- {cv.TenCongViec}");
            }
        }
    }
}
