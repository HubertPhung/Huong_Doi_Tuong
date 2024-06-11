using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_BaiOnTap2
{
    internal class Program
    {
        static ThucDon ChonMenu(int soMenu)
        {
            int menu = 0;
            while (true)
            {
                Console.Write("Nhap so Menu : ");
                if(int.TryParse(Console.ReadLine(), out menu))
                {
                    return (ThucDon)menu;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachNhanVien ds = new DanhSachNhanVien();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========Chon Chuc Nang===========");
                foreach(ThucDon i in Enum.GetValues(typeof(ThucDon)))
                {
                    Console.WriteLine($"{(int)i}. {i}");
                }
                Console.WriteLine("====================================");

                int nhanVienID;
                string ho, ten, phong;
                double luong;
                ThucDon chon = ChonMenu(0);
                switch (chon)
                {
                    case ThucDon.Thoat:
                        return;

                    case ThucDon.DocFile:
                        ds.DocFile();
                        break;
                    case ThucDon.Xuat:
                        ds.Xuat();
                        break;
                    case ThucDon.TimTheoHo:
                        ds.Xuat();
                        Console.Write("Nhập Họ cần tìm : ");
                        ds.ThuocTinh = Selector.Ho;
                        ho = Console.ReadLine();
                        ds.TimKiem(ho).Xuat();
                        
                        break;
                    case ThucDon.TimTheoTen:
                        ds.Xuat();
                        Console.Write("Nhập Tên cần tìm : ");
                        ds.ThuocTinh = Selector.Ten;
                        ten = Console.ReadLine();
                        ds.TimKiem(ten).Xuat();
                        break;
                    case ThucDon.TimTheoNVID:
                        ds.Xuat();
                        Console.Write("Nhập ID cần tìm : ");
                        ds.ThuocTinh = Selector.NhanVienID;
                        nhanVienID = int.Parse(Console.ReadLine());
                        ds.TimKiem(nhanVienID).Xuat();
                        break;
                    case ThucDon.TimTheoPhong:
                        ds.Xuat();
                        Console.Write("Nhập Họ cần tìm : ");
                        ds.ThuocTinh = Selector.Phong;
                        phong = Console.ReadLine();
                        ds.TimKiem(phong).Xuat();
                        break;
                    case ThucDon.TimTheoLuong:
                        ds.Xuat();
                        Console.Write("Nhập Lương cần tìm : ");
                        ds.ThuocTinh = Selector.Luong;
                        luong = double.Parse(Console.ReadLine());
                        ds.TimKiem(luong).Xuat();
                        break;
                    case ThucDon.SXTheoHo:
                        ds.ThuocTinh = Selector.Ho;
                        Console.WriteLine("Chưa sắp xếp :");
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Tăng : ");
                        ds.SapXep(Sort.Tang);
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Giảm : ");
                        ds.SapXep(Sort.Giam);
                        ds.Xuat();
                        break;
                    case ThucDon.SXTheoTen:
                        ds.ThuocTinh = Selector.Ten;
                        Console.WriteLine("Chưa sắp xếp :");
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Tăng : ");
                        ds.SapXep(Sort.Tang);
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Giảm : ");
                        ds.SapXep(Sort.Giam);
                        ds.Xuat();
                        break;
                    case ThucDon.SXTheoNVID:
                        ds.ThuocTinh = Selector.NhanVienID;
                        Console.WriteLine("Chưa sắp xếp :");
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Tăng : ");
                        ds.SapXep(Sort.Tang);
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Giảm : ");
                        ds.SapXep(Sort.Giam);
                        ds.Xuat();
                        break;
                    case ThucDon.SXTheoPhong:
                        ds.ThuocTinh = Selector.Phong;
                        Console.WriteLine("Chưa sắp xếp :");
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Tăng : ");
                        ds.SapXep(Sort.Tang);
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Giảm : ");
                        ds.SapXep(Sort.Giam);
                        ds.Xuat();
                        break;
                    case ThucDon.SXTheoLuong:
                        ds.ThuocTinh = Selector.Luong;
                        Console.WriteLine("Chưa sắp xếp :");
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Tăng : ");
                        ds.SapXep(Sort.Tang);
                        ds.Xuat();
                        Console.WriteLine("Sắp Xếp Giảm : ");
                        ds.SapXep(Sort.Giam);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaTheoHo:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Ho;
                        Console.Write("Nhập Họ cần xóa : ");
                        ho = Console.ReadLine();
                        ds.XoaTheoThuocTinh(ho);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaTheoTen:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Ten;
                        Console.Write("Nhập Tên cần xóa : ");
                        ten = Console.ReadLine();
                        ds.XoaTheoThuocTinh(ten);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaTheoNVID:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.NhanVienID;
                        Console.Write("Nhập ID cần xóa : ");
                        nhanVienID = int.Parse(Console.ReadLine());
                        ds.XoaTheoThuocTinh(nhanVienID);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaTheoPhong:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Phong;
                        Console.Write("Nhập Phòng cần xóa : ");
                        phong = Console.ReadLine();
                        ds.XoaTheoThuocTinh(phong);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaTheoLuong:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Luong;
                        Console.Write("Nhập Lương cần xóa : ");
                        luong = double.Parse(Console.ReadLine());
                        ds.XoaTheoThuocTinh(luong);
                        ds.Xuat();
                        break;
                    case ThucDon.HienThiDanhSachALLPhong:
                        Console.WriteLine("Danh Sách Phòng A : ");
                        ds.LocNhanVienTheoPhong("Phong A").Xuat();
                        Console.WriteLine("Danh Sách Phòng B : ");
                        ds.LocNhanVienTheoPhong("Phong B").Xuat();
                        Console.WriteLine("Danh Sách Phòng C : ");
                        ds.LocNhanVienTheoPhong("Phong C").Xuat();
                        Console.WriteLine("Danh Sách Phòng D : ");
                        ds.LocNhanVienTheoPhong("Phong D").Xuat();
                        Console.WriteLine("Danh Sách Phòng E : ");
                        ds.LocNhanVienTheoPhong("Phong E").Xuat();
                        Console.WriteLine("Danh Sách Phòng F : ");
                        ds.LocNhanVienTheoPhong("Phong F").Xuat();
                        break;
                    case ThucDon.HienThiDanhSach1PhongXacDinh:
                        Console.Write("Nhập số Phòng ban cần tìm : ");
                        phong = Console.ReadLine();
                        ds.LocNhanVienTheoPhong(phong).Xuat();
                        break;
                    case ThucDon.TongLuongALLNhanVien:
                        Console.WriteLine("Tổng lương của tất cả nhân viên là : " + ds.TongLuongALLNhanVien() + " $");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Nhan 1 phim bat ky de tiep tuc ");
                Console.ReadKey();
            }
        }

        enum ThucDon
        {
            Thoat = 0,
            DocFile,
            Xuat,
            TimTheoHo,
            TimTheoTen,
            TimTheoNVID,
            TimTheoPhong,
            TimTheoLuong,
            SXTheoHo,
            SXTheoTen,
            SXTheoNVID,
            SXTheoPhong,
            SXTheoLuong,
            XoaTheoHo,
            XoaTheoTen,
            XoaTheoNVID,
            XoaTheoPhong,
            XoaTheoLuong,
            HienThiDanhSachALLPhong,
            HienThiDanhSach1PhongXacDinh,
            TongLuongALLNhanVien

        }
    }
}
