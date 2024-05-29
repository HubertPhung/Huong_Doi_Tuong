using QuanLyAnPhamBaiLopB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312805_TNNY_Lab6
{
    class TapChi : IAnPham
    {
        float giaTien;
        string ten;
        string nhaXuatBan;
        public string diaChi;
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
        public TapChi()
        {

        }
        public TapChi(string ten, string nhaXuatBan, float giaTien, string diaChi)
        {
            Ten = ten;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
            this.diaChi = diaChi;
        }
        public TapChi(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            GiaTien = int.Parse(s[3]);
            diaChi = s[4];
        }
        public void Nhap(TapChi ap)
        {
            Console.Write("Nhập tên tạp chí: ");
            ap.Ten = Console.ReadLine();
            Console.Write("Nhập nhà xuất bản tạp chí: ");
            ap.NhaXuatBan = Console.ReadLine();
            Console.Write("Nhập địa chỉ tạp chí: ");
            ap.diaChi = Console.ReadLine();
            Console.Write("Nhập giá tạp chí: ");
            ap.GiaTien = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format($"{"Tên tạp chí",-13}: {Ten,-20}| Nhà xuất bản: {NhaXuatBan,-12}| Giá tiền: {GiaTien,-4}| Địa chỉ: {diaChi,-26}|");
        }
    }
}
