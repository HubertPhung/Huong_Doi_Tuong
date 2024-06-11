using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachAnPham
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
            DanhSachAnPham ds = new DanhSachAnPham();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================== CHỌN CHỨC NĂNG ======================================");
                foreach (ThucDon option in Enum.GetValues(typeof(ThucDon)))
                {
                    Console.WriteLine($"{(int)option}. {option}");
                }
                Console.WriteLine("===========================================================================================");
                int nam, vt;

                ThucDon chon = ChonMenu(10);
                switch (chon)
                {
                    case ThucDon.Thoat:
                        return;

                    case ThucDon.DocFile:
                        ds.DocFile("data.txt");
                        break;
                    case ThucDon.Xuat:
                        ds.Xuat();
                        break;
                    case ThucDon.Tim:
                        Console.Write("Nhập năm cần tìm : ");
                        nam = int.Parse(Console.ReadLine());
                        ds.TimKiem(nam).Xuat();
                        break;
                    case ThucDon.SapXepTang:
                        Console.WriteLine("Chưa Sắp Xếp : ");
                        ds.Xuat();
                        Console.WriteLine("Đã Sắp Xếp : ");
                        ds.ThuocTinh = Selector.Nam;
                        ds.SapXepTang();
                        ds.Xuat();
                        break;
                    case ThucDon.SapXepGiam:
                        Console.WriteLine("Chưa Sắp Xếp : ");
                        ds.Xuat();
                        Console.WriteLine("Đã Sắp Xếp : ");
                        ds.ThuocTinh = Selector.Nam;
                        ds.SapXepGiam();
                        ds.Xuat();
                        break;
                    case ThucDon.Xoa:
                        Console.WriteLine("Chưa xóa : ");
                        ds.Xuat();
                        ds.ThuocTinh = Selector.Nam;
                        Console.Write("Nhập năm cần xóa : ");
                        nam = int.Parse(Console.ReadLine());
                        ds.XoaTheoThuocTinh(nam);
                        Console.WriteLine("Đã Xóa : ");
                        ds.Xuat();
                        break;
                    case ThucDon.CapNhat:
                        ds.ThuocTinh = Selector.Nam;
                        ds.Xuat();
                        Console.Write("Nhập vị trí cần cập nhật : ");
                        vt = int.Parse(Console.ReadLine());
                        Console.Write("Nhập năm cần cập nhật : ");
                        nam = int.Parse(Console.ReadLine()) ;
                        ds.CapNhat(vt, nam);
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
            DocFile,
            Xuat,
            Tim,
            SapXepTang,
            SapXepGiam,
            CapNhat,
            Xoa,
        }
    }
}
