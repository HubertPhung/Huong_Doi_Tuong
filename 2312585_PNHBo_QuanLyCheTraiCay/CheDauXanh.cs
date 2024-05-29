using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyTreTraiCay
{
    public class CheDauXanh : Che
    {
        public CheDauXanh (string nguyenlieu, float cannang) : base(nguyenlieu, cannang)
        {

        }
        public void CheBien()
        {
            base.CheBien();
        }
        public override string ToString()
        {
            return ($"{"Chè Đậu Xanh",-16}{nguyenLieu,-50}{canNang}");
        }
    }
}
