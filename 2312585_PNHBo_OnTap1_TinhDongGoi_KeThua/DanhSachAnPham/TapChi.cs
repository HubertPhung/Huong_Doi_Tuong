using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachAnPham
{
    public class TapChi : AnPham
    {
        public int So;
        public int Tap;

        public TapChi(int so, int tap, int nam, string nhaXuatBan, string tuaDe)
            : base(nam, nhaXuatBan, tuaDe)
        {
            So = so;
            Tap = tap;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {"",-15} | {"",-14} | {So,-4} | {Tap,-5}";
        }

        
    }
}
