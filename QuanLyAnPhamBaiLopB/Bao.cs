using QuanLyAnPhamBaiLopB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312805_TNNY_Lab6
{
    class Bao : IAnPham
    {
        float giaTien;
        string ten;
        string nhaXuatBan;
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
        public Bao()
        {

        }
        public Bao(string ten, string nhaXuatBan, float giaTien)
        {
            Ten = ten;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
        }
        public Bao(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];

            GiaTien = float.Parse(s[3]);
        }
        public void Nhap(Bao ap)
        {
            Console.Write("Nhập tên báo: ");
            ap.Ten = Console.ReadLine();
            Console.Write("Nhập nhà xuất bản báo: ");
            ap.NhaXuatBan = Console.ReadLine();
            Console.Write("Nhập giá báo: ");
            ap.GiaTien = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format($"{"Tên báo",-13}: {Ten,-20}| Nhà xuất bản: {NhaXuatBan,-12}| Giá tiền: {GiaTien,-4}|{"",36}|");
        }
    }
}
