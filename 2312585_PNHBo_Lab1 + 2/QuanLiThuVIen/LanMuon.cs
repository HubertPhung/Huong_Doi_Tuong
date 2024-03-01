using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVIen
{
    internal class LanMuon
    {
        public DateTime NgayMuon;
        public DateTime NgayTra;
        public LanMuon() { }
        public LanMuon(DateTime ngayMuon, DateTime ngayTra)
        {
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ngay muon: {NgayMuon.ToShortDateString()}, Ngay tra: {NgayTra.ToShortDateString()}");
        }
    }
}
