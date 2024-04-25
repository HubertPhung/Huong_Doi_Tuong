using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal class Menu
    {
        void XuatMenu()
        {
            Console.WriteLine("========================================CHON CHUC NANG===========================================");
            Console.WriteLine("1. Nhập từ File vào danh sách collection.");
            Console.WriteLine("2. Viết phương thức thêm để thêm một IAnimal vào danh sách");
            Console.WriteLine("3. Viết phương thức ToString()");
            Console.WriteLine("4. Đếm số lượng động vật là Bat, Lion, Bird");
            Console.WriteLine("5. Đếm số lượng động vật biết bay, không biết bay");
            Console.WriteLine("6. Đếm số lượng động vật biết bay, không biết bay theo tên, tuổi");
            Console.WriteLine("7. Tìm động vật có số lượng nhiều nhất, ít nhất.");
            Console.WriteLine("8. Tìm tất cả động vật thuộc loài Bat, Lion, Bird (tương ứng thành 3 phương thức)");
            Console.WriteLine("9. Tìm tất cả động vật có tên ngắn nhất, dài nhất");
            Console.WriteLine("10.Tìm tất cả động vật có tuổi lớn nhất, nhỏ nhất");
            Console.WriteLine("11.Tìm tất cả động vật có tên ngắn nhất, dài nhất theo loài");
            Console.WriteLine("12.Tìm tất cả động vật có tuổi lớn nhất, nhỏ nhất theo loài");
            Console.WriteLine("13.Tìm danh sách các động vật biết bay");
            Console.WriteLine("14.Tìm danh sách các động vật không biết bay");
            Console.WriteLine("15.Sắp sếp theo chiều tăng, giảm của tên, tuổi");
            Console.WriteLine("=================================================================================================");
        }

        // Định nghĩa hàm chọn một menu trong danh sách
        // Input : soMenu = số lương menu có thể chọn
        // Output : số thứ tự me nu người dùng nhập vào
        int ChonMenu(int soMenu)
        {
            int stt;    // Khai báo biến menu được chọn
            do
            {
                // Xóa toàn bộ màn hình console
                Console.Clear();

              
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
        void XuLyMenu(int menu, QuanLyDongVat ds)
        {
            
            
            switch (menu)
            {
                case 1:
                    Console.WriteLine("1. Nhập từ File vào danh sách collection.");
                    ds.DocFile("data.txt");
                    ds.Xuat();
                    break;
                case 2:
                    Console.WriteLine("2. Viết phương thức thêm để thêm một IAnimal vào danh sách");
                    Console.WriteLine("Đã làm");
                    break;
                case 3:
                    Console.WriteLine("3. Viết phương thức ToString()");
                    Console.WriteLine("Đã làm");
                    break;
                case 4:
                    Console.WriteLine("4. Đếm số lượng động vật là Bat, Lion, Bird");
                    ds.DocFile("data.txt");
                    Console.WriteLine("Số lượng Bat là : " + ds.DemSLBat());
                    Console.WriteLine("Số lượng Lion là : " + ds.DemSLLion());
                    Console.WriteLine("Số lượng Bird là : " + ds.DemSLBird());
                    break;
                case 5:
                    Console.WriteLine("5.Đếm số lượng động vật biết bay, không biết bay");
                    Console.WriteLine("Số lượng động vật biết bay là : " + ds.DemSLDongVatBietBay());
                    Console.WriteLine("Số lượng động vật không biết bay là : " + ds.DemSLDongVatKhongBietBay());
                    break;
                case 6:
                    Console.WriteLine("6.Đếm số lượng động vật biết bay, không biết bay theo tên, tuổi");
                    string name;
                    int age;
                    Console.Write("Nhập tên cần đếm : ");
                    name = Console.ReadLine();
                    Console.Write("Nhập tuổi cần đếm");
                    age = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Số lượng Bat là : "+ ds.DemSLDVBietBayTheoTenTuoi(name, age));
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

        public void ChayChuongTrinh(QuanLyDongVat ds)
        {

            int menu, soMenu = 17;
            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu, ds);
            } while (menu > 0);
        }
    }

}
