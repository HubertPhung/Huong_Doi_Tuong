using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSieuThi
{
    internal class NhanVien
    {
        public KhuVuc KV;
        public string MaSoNV;
        public string TenNV;
        public DateTime NgaySinh;
        public string DiaChi;
        public string SDT;
        public DateTime NgayVaoLV;
        public string CMND;

        public NhanVien() { }
        public NhanVien(KhuVuc kV, string maSoNV, string tenNV, DateTime ngaySinh, string diaChi, string sDT, DateTime ngayVaoLV, string cMND)
        {
            KV = kV;
            MaSoNV = maSoNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = sDT;
            NgayVaoLV = ngayVaoLV;
            CMND = cMND;
        }

        public void Xuat()
        {
            Console.WriteLine("Khu vuc: " + KV.TenKV);
            Console.WriteLine("Ma so nhan vien: " + MaSoNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("Ngay sinh: " + NgaySinh.ToShortDateString());
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("So dien thoai: " + SDT);
            Console.WriteLine("Ngay vao lam viec: " + NgayVaoLV.ToShortDateString());
            Console.WriteLine("CMND: " + CMND);
        }
    }
}
