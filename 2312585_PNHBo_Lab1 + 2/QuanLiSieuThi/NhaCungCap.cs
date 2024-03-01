using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSieuThi
{
    internal class NhaCungCap
    {
        public string MaSoPB;
        public string TenCT;
        public string MaSoThue;
        public string DiaChi;
        public List<string> DanhSachSDT;
        public string Email;
        public List<MatHang> DSMatHang;


        public NhaCungCap() { }
        public NhaCungCap(string maSoPB, string tenCT, string maSoThue, string diaChi, List<string> danhSachSDT, string email, List<MatHang> dSMatHang)
        {
            MaSoPB = maSoPB;
            TenCT = tenCT;
            MaSoThue = maSoThue;
            DiaChi = diaChi;
            DanhSachSDT = danhSachSDT;
            Email = email;
            DSMatHang = dSMatHang;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma so phong ban: " + MaSoPB);
            Console.WriteLine("Ten cong ty: " + TenCT);
            Console.WriteLine("Ma so thue: " + MaSoThue);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Danh sach so dien thoai:");
            foreach (var sdt in DanhSachSDT)
            {
                Console.WriteLine("- " + sdt);
            }
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Danh sach mat hang:");
            foreach (var matHang in DSMatHang)
            {
                Console.WriteLine("- " + matHang.TenMH);
            }
        }
    }
}
