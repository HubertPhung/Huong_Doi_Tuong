using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_Lab7_TinhKeThuaVaDaKeThua
{

    public class KhachHang
    {
        public string SoCCCD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DanhSachPhuongTien dspt {  get; set; }

        public KhachHang(string soCCCD, string hoTen, string diaChi)
        {
            SoCCCD = soCCCD;
            HoTen = hoTen;
            DiaChi = diaChi;
        }

        public KhachHang(string soCCCD, string hoTen, string diaChi, DanhSachPhuongTien dspt)
        {
            SoCCCD = soCCCD;
            HoTen = hoTen;
            DiaChi = diaChi;
            this.dspt = dspt;
        }

        public KhachHang (string line)
        {
            string[] t = line.Split(';');
            SoCCCD = t[0];
            HoTen = t[1];
            DiaChi = t[2];
            


        }

        public string ThanhPho()
        {
            return DiaChi.Split(',')[2];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CCCD: {SoCCCD}");
            sb.AppendLine($"Họ và tên: {HoTen}");
            sb.AppendLine($"Địa chỉ: {DiaChi}");
            sb.AppendLine("Phương tiện:");

            return sb.ToString();
        }

    }
}
