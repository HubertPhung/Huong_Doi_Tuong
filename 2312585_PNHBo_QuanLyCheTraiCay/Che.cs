using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyTreTraiCay
{
    public class Che : TraiCay
    {
        List<NguyenLieu> ds = new List<NguyenLieu>();
        public void CheBien()
        {
            foreach (NguyenLieu i in ds)
            {
                i.CheBien();
            }
        }
        public Che(string nguyenlieu, float cannang)
        {
            nguyenLieu = nguyenlieu;
            canNang = cannang;
        }
        public Che(string tb)
        {
            string[] s = tb.Split(',');
            nguyenLieu = s[1];
            canNang = float.Parse(s[2]);
        }

        public override string ToString()
        {
            return ($"{nguyenLieu, -50}{canNang}");
        }

    }
}
