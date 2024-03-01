using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVIen
{
    internal class NguoiMuon
    {
        public string SoThe;
        public string HoTen;
        public string DiaChi;
        public string SDT;

        public NguoiMuon() { }
        public NguoiMuon(string soThe, string hoTen, string diaChi, string sdt)
        {
            SoThe = soThe;
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sdt;
        }

        public void Xuat()
        {
            Console.WriteLine($"So the: {SoThe}, Ho ten: {HoTen}, Dia chi: {DiaChi}, So dien thoai: {SDT}");
        }
    }
}
