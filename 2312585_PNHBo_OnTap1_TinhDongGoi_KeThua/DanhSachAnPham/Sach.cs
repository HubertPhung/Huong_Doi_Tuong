using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachAnPham
{
    public class Sach : AnPham
    {
        public string ISBN;
        public string TacGia;

        public Sach(string iSBN, string tacGia, int nam, string nhaXuatBan, string tuaDe)
            : base(nam, nhaXuatBan, tuaDe)
        {
            ISBN = iSBN;
            TacGia = tacGia;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {ISBN,-15} | {TacGia,-15}|";
        }

        
    }
}
