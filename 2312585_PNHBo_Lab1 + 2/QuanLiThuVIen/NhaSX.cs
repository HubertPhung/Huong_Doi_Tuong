using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVIen
{
    internal class NhaSX
    {
        public string TenNSX;
        public string DiaChi;
        public string SDT;
        public NhaSX() { }

        public NhaSX(string tenNSX, string diaChi, string sdt)
        {
            TenNSX = tenNSX;
            DiaChi = diaChi;
            SDT = sdt;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ten NSX: {TenNSX}, Dia chi: {DiaChi}, So dien thoai: {SDT}");
        }
    }
}
