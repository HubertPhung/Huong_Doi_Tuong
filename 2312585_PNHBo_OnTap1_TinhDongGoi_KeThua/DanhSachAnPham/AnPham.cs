using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachAnPham
{
    public class AnPham
    {
        public int Nam { get; set; }
        public string NhaXuatBan { get; set; }
        public string TuaDe { get; set; }

        public AnPham(int nam, string nhaXuatBan, string tuaDe)
        {
            Nam = nam;
            NhaXuatBan = nhaXuatBan;
            TuaDe = tuaDe;
        }

        public override string ToString()
        {
            return $"|{Nam,-4} | {NhaXuatBan,-12} | {TuaDe,-20}| ";
        }

        public void HienThiThongTin()
        {
            Console.WriteLine(this);
        }

    }
}
