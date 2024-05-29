using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _2312585_PNHBo_Lab7_TinhKeThuaVaDaKeThua
{
    
    public class DanhSachKhachHang
    {
        List<KhachHang> dskh = new List<KhachHang>();
        
        public void Them(KhachHang kh)
        {
            dskh.Add(kh);
        }

        public void DocFile( DanhSachPhuongTien dspt)
        {
            StreamReader sr = new StreamReader("dskh.txt");
            string line;
            KhachHang kh = null;
            while ((line = sr.ReadLine()) != null)
            {
                string[] t = line.Split(';');
                kh = new KhachHang(t[0], t[1], t[2],dspt.TimDSDieuKien(LoaiDieuKien.ChuSoHuu,null,0,0, chusohuu : t[0]));
                dskh.Add(kh);
            }
            sr.Close();
        }
        public void Xuat()
        {
            int stt = 0;
            foreach (var i in dskh)
            {
                Console.WriteLine($"===\nSTT: {++stt}");
                Console.Write(i);
                i.dspt.Xuat();
            }

        }


        //  2.Xuất danh sách khách hàng theo mẫu trên ra màn hình và file theo chiều tăng giảm của số lượng phương tiện sở hữu.
        public DanhSachKhachHang SapTangDSKH()
        {
            dskh = dskh.OrderBy(x => x.dspt.SoLuongPT()).ToList();
            return this;
        }
        public DanhSachKhachHang SapGiamDSKH()
        {
            dskh = dskh.OrderByDescending(x => x.dspt.SoLuongPT()).ToList();
            return this;
        }

        // 3. Xuất danh sách khách hàng theo mẫu trên ra màn hình và file theo từng loại phương tiện, loại điều kiện, loại so sánh, loại kết hợp.
        public DanhSachKhachHang TimDSKHCar()
        {
            return new DanhSachKhachHang{ dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Car) != 0).ToList()};
        }

        public DanhSachKhachHang TimDSKHMotorcycle()
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Motorcycle) != 0).ToList() };
        }

        public DanhSachKhachHang TimDSKHTheoTen(string ten)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.HoTen.Equals(ten)).ToList() };
        }

        public DanhSachKhachHang TimDSKHTheoCCCD(string cccd)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.SoCCCD.Contains(cccd)).ToList() };
        }

       

        //4. Tìm danh sách khách hàng sở hữu nhiều, ít nhất theo từng loại phương tiện, loại điều kiện, loại so sánh, loại kết hợp.
        public DanhSachKhachHang TimDSKHSoHuuNhieuNhatTheoPT(LoaiPhuongTien loai)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(loai) == dskh.Max(y => y.dspt.DemSoLuongTheoLoaiPhuongTien(loai))).ToList() };
        }

        public DanhSachKhachHang TimDSKHSoHuuItNhatTheoPT(LoaiPhuongTien loai)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoLoaiPhuongTien(loai) == dskh.Min(y => y.dspt.DemSoLuongTheoLoaiPhuongTien(loai))).ToList() };
        }

        public DanhSachKhachHang TimDSKHSoHuuNhieuNhatTheoTenHang(string ten)
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoTen(ten) == dskh.Max(y => y.dspt.DemSoLuongTheoTen(ten))).ToList() };
        }

        public DanhSachKhachHang TimDSKHSoHuuItNhatTheoTenHang(string ten)
        {
            
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.DemSoLuongTheoTen(ten) == dskh.Min(y => y.dspt.DemSoLuongTheoTen(ten))).ToList() };
        }

        //5.	Tìm khách hàng không sở hữu loại phương tiện nào.
        public DanhSachKhachHang TimDSKHKoCoPT()
        {
            return new DanhSachKhachHang { dskh = dskh.Where(x => x.dspt.SoLuongPT() == 0).ToList() };
        }


        //7.	Tìm thành phố có nhiều, ít loại phương tiện nhất


    }

}
