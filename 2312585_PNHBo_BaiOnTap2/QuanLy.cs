using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_BaiOnTap2
{
    public class QuanLy :  INguoi, INhanVien, IKhaNangQuanLy, IBaoCao
    {
        public string Ho {  get; set; }
        public string Ten { get; set; }
        public int NhanVienID { get; set; }
        public string Phong {  get; set; }
        
        public double Luong {  get; set; }

        public QuanLy(string ten, string ho, int nhanVienID, string phong, double luong)
        {
            Ten = ten;
            Ho = ho;
            NhanVienID = nhanVienID;
            Phong = phong;
            Luong = luong;
        }

        public void GanNhiemVu(string nhiemVu)
        { 
            Console.WriteLine("Nhiệm vụ đã được giao: " + nhiemVu);
        }

        public void TaoBaoCao()
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            Console.WriteLine("Báo cáo về nhân viên:");
            foreach (var i in dsnv.collection)
            {
                Console.WriteLine(i.LayThongTinChiTiet());
            }
        }
        public void TangLuong(double phanTram)
        {
            Luong += Luong * phanTram / 100;
        }

        public string LayTenDayDu()
        {
            return $"{Ho,-6} {Ten,-5}";
        }

        public string LayThongTinChiTiet()
        {
            return $"{LayTenDayDu(),-15} {NhanVienID,-5} {Phong,-10} {Luong,-10}";
        }
        public override string ToString()
        {
            return LayThongTinChiTiet();
        }

        

    }
}
