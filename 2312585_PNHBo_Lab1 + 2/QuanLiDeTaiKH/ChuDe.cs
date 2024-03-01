using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDeTaiKH
{
    internal class ChuDe
    {
        public string TenChuDe;

        public ChuDe(string tenChuDe)
        {
            TenChuDe = tenChuDe;
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ten chu de: {TenChuDe}");
        }
    }
}
