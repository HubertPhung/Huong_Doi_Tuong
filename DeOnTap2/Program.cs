using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnTap2
{
    public class Program
    {
        static ThucDon ChonMenu(int soMenu)
        {
            int menu = 0;
            while(true)
            {
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
            while(true)
            {
                Console.Clear();
                Console.WriteLine(new string('=',20) + "Chon Menu" + new string('=', 20));
                foreach(ThucDon i in Enum.GetValues(typeof(ThucDon)))
                {
                    Console.WriteLine($"{(int)i}. {i}");
                }
                Console.WriteLine(new string('=',49));
                ThucDon chon = ChonMenu(10);
                switch (chon)
                {
                    case ThucDon.NhapTuFile:
                        ds.NhapTuFile();
                        break;
                    case ThucDon.Xuat:
                        ds.Xuat();
                        break;
                    case ThucDon.Thoat:
                        break;
                    case ThucDon.TimNhanVienTuoi_Max:
                        ds.TimTuoiNhanVien(ds.TimNhanVienTuoi_Max()).Xuat();
                        break;
                    case ThucDon.SapXepNamSinhTang:
                        break;
                    case ThucDon.XoaTheoTen:
                        ds.Xuat();
                        Console.Write("Nhap ten can xoa : ");
                        string ten = Console.ReadLine();
                        ds.XoaTheoTen(ten);
                        ds.Xuat();
                        break;
                    case ThucDon.TimNhanCoNguoiThanLamCung:

                        break;
                    case ThucDon.DanhSachNamVaSoNhanVien:
                        Dictionary<int, List<string>> dsss = ds.DanhSachNamVaSoNhanVien();
                        foreach(var i in dsss)
                        {
                            Console.WriteLine($"{i.Key}  {string.Join(", ",i.Value)}");
                        }
                        break;
                }

                Console.WriteLine("Nhấn phím bất kỳ để tiếp tục");
                Console.ReadKey();
            }


        }

        public enum ThucDon
        {
            NhapTuFile=1,
            Xuat,
            Thoat,
            TimNhanVienTuoi_Max,
            SapXepNamSinhTang,
            XoaTheoTen,
            TimNhanCoNguoiThanLamCung,
            DanhSachNamVaSoNhanVien

        }
    }
}
