using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thay đổi bảng mã màn hình console
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv1 = new SinhVien("2312585", "Phùng Nguyễn Hoài Bo", new DateTime(2005, 4, 3), GioiTinh.Nam);
            SinhVien sv2 = new SinhVien("2312802", "Phan Khánh Vương", new DateTime(2005, 1, 24), GioiTinh.Nam);
            SinhVien sv3 = new SinhVien("2312639", "Vũ Thế Huỳnh", new DateTime(2005, 10, 1), GioiTinh.Nam);
            SinhVien sv4= new SinhVien("12345", "Nguyễn Văn Ú", new DateTime(2005, 1, 1), GioiTinh.Nam);
            SinhVien sv5 = new SinhVien("12345", "Nguyễn Văn Ú", new DateTime(2005, 1, 1), GioiTinh.Nam);
            SinhVien sv6 = new SinhVien("12345", "Nguyễn Văn Ú", new DateTime(2005, 1, 1), GioiTinh.Nam);
            SinhVien sv7 = new SinhVien("12345", "Nguyễn Văn Ú", new DateTime(2005, 1, 1), GioiTinh.Nam);
            // Thêm sinh vien vào lớp
            Lop lopk47 = new Lop("CTK47A");
            lopk47.ThemSV(sv1);
            lopk47.ThemSV(sv2);
            lopk47.ThemSV(sv3);
            lopk47.ThemSV(sv4);
            lopk47.ThemSV(sv5);
            lopk47.ThemSV(sv6);
            lopk47.ThemSV(sv7);

            lopk47.NhapDuLieu("Data.txt");
            Console.WriteLine(lopk47);
            Console.ReadKey();
        }
    }
}
