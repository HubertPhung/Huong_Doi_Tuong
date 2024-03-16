using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Menu
    {
        void XuatMenu()
        {
            Console.WriteLine("========================================CHON CHUC NANG===========================================");
            Console.WriteLine("1.Đếm số lượng sinh viên Nam trong lớp");
            Console.WriteLine("2.Đếm số lượng sinh viên Nu trong lớp");
            Console.WriteLine("3.Hiển thị danh sách sinh viên theo chiếu tăng, giảm của điểm trung bình");
            Console.WriteLine("4.Tìm danh sách sinh viên có điểm trung bình cao nhất");
            Console.WriteLine("5.Tìm lớp có sinh viên có điểm trung bình cao nhất");
            Console.WriteLine("6.Tìm lớp có sinh viên không có điểm trung bình cao nhất");
            Console.WriteLine("7.Hiển thị danh sách sinh viên theo lớp và theo chiều giảm của điểm trung bình");
            Console.WriteLine("8.Xếp hạng sinh viên của lớp");
            Console.WriteLine("9.Tìm lớp có tổng điểm trung bình cao nhất, thấp nhất");
            Console.WriteLine("10.Tìm lớp có nhiều sinh viên giỏi nhất");
            Console.WriteLine("11.Tìm lớp có nhiều (hoặc ít) sinh viên theo loại yếu, trung bình, khá");
            Console.WriteLine("12.Ghi xuống file danh sách lớp ");
            Console.WriteLine("13.Tìm lớp không có sinh viên nữ");
            Console.WriteLine("14.Tìm lớp không có sinh viên nam");
            Console.WriteLine("15.Đếm số lượng sinh viên theo lớp");
            Console.WriteLine("16.Xóa tất cả sinh viên của lớp nào đó");
            Console.WriteLine("17.Xếp loại sinh viên dựa trên điểm trung bình");
            Console.WriteLine("=================================================================================================");
        }

        // Định nghĩa hàm chọn một menu trong danh sách
        // Input : soMenu = số lương menu có thể chọn
        // Output : số thứ tự me nu người dùng nhập vào
        int ChonMenu(int soMenu, DanhSachSinhVien ds, SinhVien sv)
        {
            int stt;    // Khai báo biến menu được chọn
            do
            {
                // Xóa toàn bộ màn hình console
                Console.Clear();

                ds.XuatXepLoaiDSSV(sv);
                // Gọi hàm xuát danh sách chức năng (menu)
                XuatMenu();

                // Thông báo cho người dùng chọn menu
                Console.Write("Nhập chức năng cần chọn: ");

                // Chờ người dùng nhập/chọn menu
                stt = Convert.ToInt32(Console.ReadLine());
            } while (stt < 0 || stt > soMenu);
            return stt;
        }

        // Định nghĩa hàm xử lý menu tùy thuộc vào chức năng 
        // do người dùng chọn chức năng là gì.
        // Input : menu = Số thứ tự menu do người chọn
        // Outut : không có
        void XuLyMenu(int menu, DanhSachSinhVien ds, DanhSachSinhVien dsphu, SinhVien sv)
        {
            
            switch (menu)
            {
                case 1:
                    //1. Đếm số lượng sinh viên Nam trong lớp
                    Console.Write(ds);
                    Console.WriteLine("1. Đếm số lượng sinh viên Nam trong lớp");
                    Console.Write("Nhập tên lớp : ");
                    string lop = Console.ReadLine();
                    Console.WriteLine($"Số lượng sinh viên nam là : {ds.DemSoLuongSVNam(lop)}");
                    break;

                case 2:
                    //2. Đếm số lượng sinh viên Nu trong lớp
                    Console.Write(ds);
                    Console.Write("Nhập tên lớp : ");
                    string lop1 = Console.ReadLine();
                    Console.WriteLine($"2. Số lượng sinh viên nữ trong lớp : {ds.DemSoLuongSVNu(lop1)}");
                    break;

                case 3:
                    //3. Hiển thị danh sách sinh viên theo chiếu tăng, giảm của điểm trung bình
                    Console.WriteLine("3. Hiển thị danh sách sinh viên theo chiều tăng, giảm của điểm trung bình");
                    Console.WriteLine("Danh sách tăng :");
                    ds.SapXepTangTheoDTB();
                    Console.Write(ds);
                    Console.WriteLine("Danh sách giảm : ");
                    ds.SapXepGiamTheoDTB();
                    Console.Write(ds);
                    break;
                case 4:
                    //4. Tìm danh sách sinh viên có điểm trung bình cao nhất
                    Console.WriteLine("4. Tìm danh sách sinh viên có điểm trung bình cao nhất : ");
                    ds.TimDSSVCoDTBCaoNhat();
                    Console.Write(ds);
                    break;
                case 5:
                    //5. Tìm lớp có sinh viên có điểm trung bình cao nhất
                    Console.Write("5. Tìm lớp có sinh viên có điểm trung bình cao nhất : ");
                    ds.XuatRaLopCoDTBCaoNhat();
                    Console.WriteLine();
                    break;
                case 6:
                    //6. Tìm lớp có sinh viên không có điểm trung bình cao nhất
                    Console.Write("6. Tìm lớp có sinh viên không có điểm trung bình cao nhất : ");
                    ds.XuatRaLopKoCoDTBCaoNhat();
                    Console.WriteLine();
                    break;
                case 7:
                    //7. Hiển thị danh sách sinh viên theo lớp và theo chiều giảm của điểm trung bình
                    Console.Write(ds);
                    Console.WriteLine("7. Hiển thị danh sách sinh viên theo lớp và theo chiều giảm của điểm trung bình");
                    Console.Write("Nhập vào lớp cần tìm: ");
                    string lop_case7 = Console.ReadLine();
                    dsphu = ds.SinhVienTheoLop(lop_case7);
                    dsphu.SapXepGiamTheoDTB();
                    Console.WriteLine(dsphu);
                    break;
                case 8:
                    //8. Xếp hạng sinh viên của lớp
                    break;
                case 9:
                    //9. Tìm lớp có tổng điểm trung bình cao nhất, thấp nhất
                    Console.WriteLine("9. Tìm lớp có tổng điểm trung bình cao nhất, thấp nhất");
                    Console.WriteLine("Lớp cao nhất:");
                    Console.WriteLine(ds.LopCoTongDTBCaoNhat());
                    Console.WriteLine(ds.TongDTBCuaCacLop().Max() + " điểm");

                    Console.WriteLine("Lớp thấp nhất:");
                    Console.WriteLine(ds.LopCoTongDTBThapNhat());
                    Console.WriteLine(ds.TongDTBCuaCacLop().Min() + " điểm");
                    break;
                case 10:
                    //10. Tìm lớp có nhiều sinh viên giỏi nhất
                    Console.WriteLine("10. Tìm lớp có nhiều sinh viên giỏi nhất");
                    Console.WriteLine("Lớp có nhiều sinh viên giỏi nhất là : "+ds.TimLopCoNhieuSVGioiNhat("Gioi"));
                    break;
                case 11:
                    //11. Tìm lớp có nhiều (hoặc ít) sinh viên theo loại yếu, trung bình, khá
                    Console.WriteLine("11. Tìm lớp có nhiều (hoặc ít) sinh viên theo loại yếu, trung bình, khá");
                    Console.WriteLine("Lớp có nhiều sinh viên khá nhất là : " + ds.TimLopCoNhieuSVGioiNhat("Kha"));
                    Console.WriteLine("Lớp có nhiều sinh viên TB nhất là : " + ds.TimLopCoNhieuSVGioiNhat("TB"));
                    Console.WriteLine("Lớp có nhiều sinh viên Yếu nhất là : " + ds.TimLopCoNhieuSVGioiNhat("Yeu"));
                    break;
                case 12:
                    //12. Ghi xuống file danh sách lớp 
                    break;
                case 13:
                    //13. Tìm lớp không có sinh viên nữ
                    Console.Write("13. Tìm lớp không có sinh viên nữ : ");
                    ds.XuatLop(ds.TimLopKhongCoNu());
                    break;
                case 14:
                    //14. Tìm lớp không có sinh viên nam
                    Console.Write("14. Tìm lớp không có sinh viên nam : ");
                    ds.XuatLop(ds.TimLopKhongCoNam());
                    break;
                case 15:
                    //15. Đếm số lượng sinh viên theo lớp
                    Console.WriteLine("15. Đếm số lượng sinh viên theo lớp");
                    ds.XuatMap(ds.ThongKeSVTheoLop());
                    break;
                case 16:
                    //16. Xóa tất cả sinh viên của lớp nào đó
                    Console.WriteLine("16. Xóa tất cả sinh viên của lớp nào đó");
                    Console.Write("Nhập lớp cần xóa : ");
                    string lop2 = Console.ReadLine();
                    ds.XoaSinhVienTheoLop(lop2);
                    ds.XuatXepLoaiDSSV(sv);
                    break;
                case 17:
                    //17. Xếp loại sinh viên dựa trên điểm trung bình
                    Console.WriteLine("17. Xếp loại sinh viên dựa trên điểm trung bình");
                    ds.XuatXepLoaiDSSV(sv);
                    break;
                    
                default:
                    Console.WriteLine("Thoát chương trình. ");
                    break;
            }
            if (menu > 0)
            {
                Console.WriteLine("\nNhấn một phím bất kỳ để tiếp tục ");
                Console.ReadKey();
            }

        }

        public void ChayChuongTrinh(DanhSachSinhVien ds, DanhSachSinhVien dsphu, SinhVien sv)
        {
            
            int menu, soMenu = 17;
            do
            {
                menu = ChonMenu(soMenu, ds, sv);
                XuLyMenu(menu, ds, dsphu, sv);
            } while (menu > 0);
        }


    }
}
