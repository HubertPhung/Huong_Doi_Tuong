using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyTreTraiCay
{
    public class CheThai : Che
    {
        public CheThai(string nguyenlieu, float cannang) : base (nguyenlieu, cannang)
        {

        }

        public  void CheBien()
        {
            base.CheBien();
        }

        public override string ToString()
        {
            return ($"{"Chè Thái",-16}{nguyenLieu,-50}{canNang}");
        }
    }
}
