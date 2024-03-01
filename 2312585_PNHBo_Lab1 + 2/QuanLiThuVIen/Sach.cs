using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVIen
{
    internal class Sach
    {
        public string MaSach;
        public string TenSach;

        public NhaSX NSX;
        public string TacGia;

        public Sach() { }
        public Sach(string maSach, string tenSach, NhaSX nsx, string tacGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            NSX = nsx;
            TacGia = tacGia;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma sach: {MaSach}, Ten sach: {TenSach}, Nha san xuat: {NSX.TenNSX}, Tac gia: {TacGia}");
        }
    }
}
