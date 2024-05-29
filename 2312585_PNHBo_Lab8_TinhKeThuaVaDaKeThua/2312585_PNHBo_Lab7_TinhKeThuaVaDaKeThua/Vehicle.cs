using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _2312585_PNHBo_Lab7_TinhKeThuaVaDaKeThua
{
    public class Vehicle : IVehicle
    {
        public string ChuSoHuu {  get; set; }
        public string MaPhuongTien { get; set; }
        public string Ten { get; set; }
        public int TocDo { get; set; }
        public void Chay()
        {
            Console.WriteLine("Vehicle is running");
        }
        public void Dung()
        {
            Console.WriteLine("Vehicle is stopping");
        }

        
        public Vehicle(string ten, int tocDo, string maphuongtien, string chusohuu)
        {
            MaPhuongTien = maphuongtien;
            Ten = ten;
            TocDo = tocDo;
            ChuSoHuu = chusohuu;
        }
        
        public Vehicle(string tb)
        {
            string[] s = tb.Split(',');
            MaPhuongTien = s[0];
            Ten = s[1];
            TocDo = int.Parse(s[2]);
            ChuSoHuu = s[3];
        }

        public override string ToString()
        {
            return $"{MaPhuongTien,-15}{Ten,-16} {TocDo,-10}";
        }
    }
}
