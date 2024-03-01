using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDuAn
{
    internal class ThanNhan
    {
        public string HoTen;
        public string GioiTinh;
        public DateTime NgaySinh;
        public string MoiQuanHe;

        public ThanNhan() { }
        public ThanNhan(string hoTen, string gioiTinh, DateTime ngaySinh, string moiQuanHe)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            MoiQuanHe = moiQuanHe;
        }
        public void Xuat()
        {
            Console.WriteLine("Ho Ten: " + HoTen);
            Console.WriteLine("Gioi Tinh: " + GioiTinh);
            Console.WriteLine("Ngay Sinh: " + NgaySinh.ToShortDateString());
            Console.WriteLine("Moi Quan He: " + MoiQuanHe);
        }

    }

}
