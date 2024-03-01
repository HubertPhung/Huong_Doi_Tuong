using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVIen
{
    internal class ChiNhanh
    {
        public string MaCN;
        public string TenCN;
        public string DiaChi;
        public ChiNhanh() { }
        public ChiNhanh(string maCN, string tenCN, string diaChi)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChi = diaChi;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma chi nhanh: {MaCN}, Ten chi nhanh: {TenCN}, Dia chi: {DiaChi}");
        }
    }
}
