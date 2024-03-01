using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVIen
{
    internal class BanSaoSach
    {
        public Sach Sach;
        public int SoBanSao;
        public BanSaoSach() { }
        public BanSaoSach(Sach sach, int soBanSao)
        {
            Sach = sach;
            SoBanSao = soBanSao;
        }

        public void Xuat()
        {
            Console.WriteLine($"Sach: {Sach.MaSach}, So ban sao: {SoBanSao}");
        }
    }
}
