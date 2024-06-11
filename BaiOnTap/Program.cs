using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTap
{
    internal class Program
    {
        static ThucDon ChonMenu(int soMenu)
        {
            int menu = 0;
            while (true)
            {
                Console.Write("Nhap so Menu : ");
                if (int.TryParse(Console.ReadLine(), out menu))
                {
                    return (ThucDon)menu;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachAnPham ds = new DanhSachAnPham();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========Chon Chuc Nang===========");
                foreach (ThucDon i in Enum.GetValues(typeof(ThucDon)))
                {
                    Console.WriteLine($"{(int)i}. {i}");
                }
                Console.WriteLine("====================================");
                string nhaXuatBan;
                ThucDon chon = ChonMenu(0);
                Console.Clear();

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
                    case ThucDon.TimAnPham_MaxGia:
                        Console.WriteLine("Danh sach an pham co gia tien lon nhat la:");
                        //float max = ds.TimGiaTienLonNhat();
                        //DanhSachAnPham kq = ds.TimAnPhamTheoGia(max);
                        //kq.Xuat();
                        ds.TimAnPhamTheoGia(ds.TimGiaTienLonNhat()).Xuat();
                        Console.WriteLine("Danh sach an pham co gia tien nho nhat la:");
                        ds.TimAnPhamTheoGia(ds.TimGiaTienNhoNhat()).Xuat();
                        break;
                    case ThucDon.SapXep_TangTen:
                        Console.WriteLine("Danh sach ban dau:");
                        ds.Xuat();
                        Console.WriteLine("Danh sach sau khi sap tang theo ten:");
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.TimTruyenTranh:
                        ds.Xuat();
                        Console.Write("Nhập tên nhà xuất bản cần tìm cần tìm : ");
                        nhaXuatBan = Console.ReadLine();
                        ds.TimTruyenTranh(nhaXuatBan).Xuat();
                        break;
                    case ThucDon.SapXep_TangGiaTien:
                        ds.ThuocTinh = Selector.GiaTien;
                        ds.SapXep();
                        ds.Xuat();
                        break;
                    case ThucDon.SapXepTruyenTranhGiamDan:
                        //SoSanh soSanh = delegate (IAnPham x, IAnPham y)
                        //{
                        //    return y.Ten.CompareTo(x.Ten);
                        //};
                        ds.ThuocTinh = Selector.TenGiam;
                        ds.SapXepTruyenTranhGiamDan(ds.Compare);
                        ds.Xuat();
                        break;
                    case ThucDon.TimALLAnPhamCoGiaTienLonHonY:
                        Console.Write("Nhập giá Tiền y : ");
                        float y = float.Parse(Console.ReadLine());
                        ds.TimALLAnPhamCoGiaTienLonHonY(y).Xuat();

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
            TimAnPham_MaxGia,
            SapXep_TangTen,
            TimTruyenTranh,
            SapXep_TangGiaTien,
            SapXepTruyenTranhGiamDan,
            TimALLAnPhamCoGiaTienLonHonY
        }
    }
}
