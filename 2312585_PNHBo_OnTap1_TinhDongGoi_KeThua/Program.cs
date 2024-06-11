using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_TinhDongGoi_KeThua
{
    public class Program
    {
        private static ThucDon ChonMenu(int soMenu)
        {
            int menu = 0;
            while (true)
            {
                Console.Write("Nhập số Menu : ");
                if (int.TryParse(Console.ReadLine(), out menu))
                    return (ThucDon)menu;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyNhanVien ds = new QuanLyNhanVien();
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================== CHỌN CHỨC NĂNG ======================================");
                foreach (ThucDon option in Enum.GetValues(typeof(ThucDon)))
                {
                    Console.WriteLine($"{(int)option}. {option}");
                }
                Console.WriteLine("===========================================================================================");
                string ten, maNV, phong, viTri, diaChi;
                int vt, tuoi;
                decimal luong;
                
                ThucDon chon = ChonMenu(10);
                switch (chon)
                {
                    case ThucDon.NhapTuFile:
                        ds.DocFile("data.txt");
                        break;
                    case ThucDon.Xuat:
                        ds.Xuat();
                        break;
                    case ThucDon.NhapThuCong:

                        Console.Write("Nhập số lượng người muốn thêm:");
                        int soLuong = int.Parse(Console.ReadLine());
                        for (int i = 0; i < soLuong; i++)
                        {
                            ds.NhapThongTinThuCong();
                        }
                        break;
                    case ThucDon.TimTheoTen:
                        ds.Xuat();
                        Console.Write("Nhập Tên cần tìm : ");
                        ten = Console.ReadLine();
                        ds.ThuocTinh = Selector.Ten;
                        ds.TimKiem(ten).Xuat();
                        break;
                    case ThucDon.TimTheoMaNV:
                        ds.Xuat();
                        Console.Write("Nhập Mã Nhân Viên cần tìm : ");
                        maNV = Console.ReadLine();
                        ds.ThuocTinh = Selector.MaNhanVien;
                        ds.TimKiem(maNV).Xuat();
                        break;
                    case ThucDon.SapXepTheoTen:
                        Console.WriteLine("Danh sách ban đầu");
                        ds.Xuat();
                        Console.WriteLine("Danh sách sau khi sắp xếp");
                        ds.ThuocTinh = Selector.Ten;
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.SapXepTheoMaNV:
                        Console.WriteLine("Danh sách ban đầu");
                        ds.Xuat();
                        Console.WriteLine("Danh sách sau khi sắp xếp");
                        ds.ThuocTinh = Selector.MaNhanVien;
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.Thoat:
                        return;
                    case ThucDon.CapNhatTen:
                        ds.ThuocTinh = Selector.Ten;
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập tên mới : ");
                        ten = Console.ReadLine();
                        ds.CapNhat(vt, ten);
                        ds.Xuat();
                        break;
                    case ThucDon.ChenNhanVienMoiVaoViTri:
                        Console.Write("Nhập vị trí cần Chèn :");
                        vt = int.Parse(Console.ReadLine());
                        NhanVien nhanVienMoi = new NhanVien(10000, "2312585", "Truong Phong IT", "Da Lat", "Phung Nguyen Hoai Bo", 19);
                        ds.Chen(vt, nhanVienMoi);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaPhong:
                        Console.Write("Nhập phòng cần xóa : ");
                        phong = Console.ReadLine();
                        ds.XoaALLQuanLyCua1Phong(phong);
                        break;
                    case ThucDon.TimTheoTuoi:
                        Console.Write("Nhập Tuổi cần tìm : ");
                        tuoi = int.Parse(Console.ReadLine());
                        ds.ThuocTinh = Selector.Tuoi;
                        ds.TimKiem(tuoi).Xuat();
                        break;
                    case ThucDon.TimTheoDiaChi:
                        Console.Write("Nhập Địa chỉ cần tìm : ");
                        diaChi = Console.ReadLine(); 
                        ds.ThuocTinh = Selector.DiaChi;
                        ds.TimKiem(diaChi).Xuat();
                        break;
                    case ThucDon.TimTheoLuong:
                        Console.Write("Nhập Lương cần tìm : ");
                        luong = decimal.Parse(Console.ReadLine());
                        ds.ThuocTinh = Selector.Luong;
                        ds.TimKiem(luong).Xuat();
                        break;
                    case ThucDon.TimTheoViTri:
                        Console.Write("Nhập Vị Trí cần tìm : ");
                        viTri = Console.ReadLine();
                        ds.ThuocTinh = Selector.ViTri;
                        ds.TimKiem(viTri).Xuat();
                        break;
                    case ThucDon.TimTheoPhong:
                        Console.Write("Nhập Phong cần tìm : ");
                        phong = Console.ReadLine();
                        ds.ThuocTinh = Selector.Phong;
                        ds.TimKiem(phong).Xuat();
                        break;
                    case ThucDon.SapXepTheoTuoi:
                        Console.WriteLine("Chưa Sắp Xếp : ");
                        ds.Xuat();
                        Console.WriteLine("Đã Sắp Xếp : ");
                        ds.ThuocTinh = Selector.Tuoi;
                        ds.SapXep();
                        ds.Xuat();  
                        break;
                    case ThucDon.SapXepTheoDiaChi:
                        Console.WriteLine("Chưa Sắp Xếp : ");
                        ds.Xuat();
                        Console.WriteLine("Đã Sắp Xếp : ");
                        ds.ThuocTinh = Selector.DiaChi;
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.SapXepTheoLuong:
                        Console.WriteLine("Chưa Sắp Xếp : ");
                        ds.Xuat();
                        Console.WriteLine("Đã Sắp Xếp : ");
                        ds.ThuocTinh = Selector.Luong;
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.SapXepTheoViTri:
                        Console.WriteLine("Chưa Sắp Xếp : ");
                        ds.Xuat();
                        Console.WriteLine("Đã Sắp Xếp : ");
                        ds.ThuocTinh = Selector.ViTri;
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.CapNhatMaNV:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.MaNhanVien;
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập mã NV cần thay đổi : ");
                        maNV = Console.ReadLine();
                        ds.CapNhat(vt, maNV);
                        ds.Xuat();
                        break;
                    case ThucDon.CapNhatTuoi:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Tuoi;
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập tuổi cần thay đổi : ");
                        tuoi = int.Parse(Console.ReadLine());
                        ds.CapNhat(vt, tuoi);
                        ds.Xuat();
                        break;
                    case ThucDon.CapNhatDiaChi:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.DiaChi;
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập địa chỉ cần thay đổi : ");
                        diaChi = Console.ReadLine();
                        ds.CapNhat(vt, diaChi);
                        ds.Xuat();
                        break;
                    case ThucDon.CapNhatLuong:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Luong;
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập lương cần thay đổi : ");
                        luong = decimal.Parse(Console.ReadLine());
                        ds.CapNhat(vt, luong);
                        ds.Xuat();
                        break;
                    case ThucDon.CapNhatViTri:
                        ds.Xuat();
                        ds.ThuocTinh = Selector.ViTri;
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập vị trí nhân viên cần thay đổi : ");
                        viTri = Console.ReadLine();
                        ds.CapNhat(vt, viTri);
                        ds.Xuat();
                        break;
                    default:
                        return;
                }
                Console.WriteLine("Nhap 1 phim de tiep tuc ");
                Console.ReadKey();
            }
        }

        public enum ThucDon
        {
            Thoat = 0,
            NhapThuCong,
            NhapTuFile,
            Xuat,
            TimTheoTen,
            TimTheoMaNV,
            TimTheoTuoi,
            TimTheoDiaChi,
            TimTheoLuong,
            TimTheoViTri,
            TimTheoPhong,
            SapXepTheoTen,
            SapXepTheoMaNV,
            SapXepTheoTuoi,
            SapXepTheoDiaChi,
            SapXepTheoLuong,
            SapXepTheoViTri,
            CapNhatTen,
            CapNhatMaNV,
            CapNhatTuoi,
            CapNhatDiaChi,
            CapNhatLuong,
            CapNhatViTri,
            ChenNhanVienMoiVaoViTri,
            XoaPhong,
        }
    }
}
