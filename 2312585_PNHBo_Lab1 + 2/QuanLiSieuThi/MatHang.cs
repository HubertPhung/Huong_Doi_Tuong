using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSieuThi
{
    internal class MatHang
    {
        public string MaSoMH;
        public string TenMH;
        public float DonViTinh;
        public float DonGia;
        public List <NhaCungCap> NhaCungUng;

        public MatHang() { }

        public MatHang(string maSoMH, string tenMH) {
            MaSoMH = maSoMH;
            TenMH = tenMH;
        }

        public MatHang(string maSoMH, string tenMH, float donViTinh, float donGia, List<NhaCungCap> nhaCungUng)
        {
            MaSoMH = maSoMH;
            TenMH = tenMH;
            DonViTinh = donViTinh;
            DonGia = donGia;
            NhaCungUng = nhaCungUng;
        }

        public void Xuat()
        {
            Console.WriteLine("Ma so mat hang: " + MaSoMH);
            Console.WriteLine("Ten mat hang: " + TenMH);
            Console.WriteLine("Don vi tinh: " + DonViTinh);
            Console.WriteLine("Don gia: " + DonGia);
            Console.WriteLine("Nha cung ung:");
            foreach (var nhaCungUngItem in NhaCungUng)
            {
                Console.WriteLine("- " + nhaCungUngItem.TenCT);
            }
        }

    }
}
