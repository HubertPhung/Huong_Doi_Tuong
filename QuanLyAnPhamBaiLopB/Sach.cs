using QuanLyAnPhamBaiLopB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312805_TNNY_Lab6
{
    class Sach : IAnPham
    {
        float giaTien;
        string ten;
        string nhaXuatBan;
        public int SoTrang;
        public float GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }
        public string NhaXuatBan
        {
            get
            {
                return nhaXuatBan;
            }

            set
            {
                nhaXuatBan = value;
            }
        }
        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
        public Sach()
        {

        }
        public Sach(string ten, string nhaXuatBan, float giaTien, int soTrang)
        {
            Ten = ten;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
            SoTrang = soTrang;
        }
        public Sach(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            SoTrang = int.Parse(s[3]);
            GiaTien = float.Parse(s[4]);
        }
        public void Nhap(Sach ap)
        {
            Console.Write("Nhập tên sách: ");
            ap.Ten = Console.ReadLine();
            Console.Write("Nhập nhà xuất bản sách: ");
            ap.NhaXuatBan = Console.ReadLine();
            Console.Write("Nhập giá sách: ");
            ap.GiaTien = int.Parse(Console.ReadLine());
            Console.Write("Nhập số trang sách: ");
            ap.SoTrang = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format($"{"Tên sách",-13}: {Ten,-20}| Nhà xuất bản: {NhaXuatBan,-12}| Giá tiền: {GiaTien,-4}| Số trang : {SoTrang,-24}|");
        }
    }
}
