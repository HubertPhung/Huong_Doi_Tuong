using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312805_TNNY_Lab6
{
    internal class Menu : DanhSachAnPham
    {
        private enum MenuCT
        {
            Thoát_chương_trình,
            Đọc_danh_sách_ấn_phẩm_từ_file,
            Xuất_danh_sách_ấn_phẩm,
            Tìm_ấn_phẩm_có_giá_lớn_nhất,
            Tìm_danh_sách_ấn_phẩm_thuộc_nhà_xuất_bản_x,
            Hiển_thị_các_ấn_phấm_theo_giá,
            Tính_tổng_giá_tiền_của_danh_sách_ấn_phẩm,
            Sắp_xếp_danh_sách_ấn_phẩm_giảm_theo_tên_giảm_theo_giá,
            Sắp_xếp_danh_sách_ấn_phẩm_tăng_theo_tên_tăng_theo_giá,
            Tìm_các_ấn_phẩm_có_giá_thấp_nhất,
            Xóa_tất_cả_ấn_phẩm_có_giá_thấp_nhất,
            Chèn_ấn_phẩm_vào_danh_sách_ấn_phẩm_trước_vị_trí_i,
        }
        private void XuatMenu()
        {
            Console.WriteLine("=========================================================MENU=========================================================");
            for (int i = (int)MenuCT.Thoát_chương_trình; i <= (int)MenuCT.Chèn_ấn_phẩm_vào_danh_sách_ấn_phẩm_trước_vị_trí_i; i++)
                Console.WriteLine("{0,-2}. {1}.", i, ((MenuCT)i).ToString().Replace('_', ' '));
            Console.WriteLine("======================================================================================================================");
        }
        private MenuCT ChonMenu()
        {
            int chon;
            do
            {
                Console.Write("Nhập menu [{0},{1}] = ", (int)MenuCT.Thoát_chương_trình, (int)MenuCT.Chèn_ấn_phẩm_vào_danh_sách_ấn_phẩm_trước_vị_trí_i);
                chon = int.Parse(Console.ReadLine());
            } while (chon < (int)MenuCT.Thoát_chương_trình || chon > (int)MenuCT.Chèn_ấn_phẩm_vào_danh_sách_ấn_phẩm_trước_vị_trí_i);
            return (MenuCT)chon;
        }
        private void XuLyMenu(MenuCT chon)
        {
            if (collection.Count() == 0 && chon != MenuCT.Đọc_danh_sách_ấn_phẩm_từ_file)
                NhapTuFile();
            switch (chon)
            {
                case MenuCT.Thoát_chương_trình:
                    break;

                case MenuCT.Đọc_danh_sách_ấn_phẩm_từ_file:
                    NhapTuFile();
                    Console.WriteLine(ToString());
                    break;

                case MenuCT.Xuất_danh_sách_ấn_phẩm:
                    Console.WriteLine(ToString());
                    break;

                case MenuCT.Tìm_ấn_phẩm_có_giá_lớn_nhất:
                    Console.WriteLine(ToString());
                    Console.WriteLine("Danh sách ấn phẩm có giá lớn nhất: \n{0}", TimAnPhamCoGiaCaoNhat());
                    break;

                case MenuCT.Tìm_danh_sách_ấn_phẩm_thuộc_nhà_xuất_bản_x:
                    Console.WriteLine(ToString());
                    Console.Write("Nhập tên nhà xuất bản cần tìm: ");
                    string x = Console.ReadLine();
                    Console.WriteLine("Danh sách các ấn phẩm thuộc nhà xuất bản {0}: \n{1}", x, DSAPTheoNXB(x));
                    break;

                case MenuCT.Hiển_thị_các_ấn_phấm_theo_giá:
                    Console.WriteLine(ToString());
                    Console.Write("Nhập giá cần tìm: ");
                    float y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Danh sách ấn phẩm có giá {0}:\n{1}", y, TimAnPhamTheoGiaTien(y));
                    break;

                case MenuCT.Tính_tổng_giá_tiền_của_danh_sách_ấn_phẩm:
                    Console.WriteLine(ToString());
                    Console.WriteLine("Tổng giá tiền của danh sách ấn phẩm: {0}", TongGiaDSAP());
                    break;

                case MenuCT.Sắp_xếp_danh_sách_ấn_phẩm_giảm_theo_tên_giảm_theo_giá:
                    Console.WriteLine("Danh sách ấn phẩm trước sắp xếp:\n{0}", ToString());
                    SapXepGiamTheoGia();
                    Console.WriteLine("Danh sách ấn phẩm sau sắp xếp:\n{0}", ToString());
                    break;

                case MenuCT.Sắp_xếp_danh_sách_ấn_phẩm_tăng_theo_tên_tăng_theo_giá:
                    Console.WriteLine("Danh sách ấn phẩm trước sắp xếp:\n{0}", ToString());
                    SapXepTangTheoGia();
                    Console.WriteLine("Danh sách ấn phẩm sau sắp xếp:\n{0}", ToString());
                    break;

                case MenuCT.Tìm_các_ấn_phẩm_có_giá_thấp_nhất:
                    Console.WriteLine(ToString());
                    Console.WriteLine("Danh sách ấn phẩm có giá thấp nhất:\n{0}", DSAPGiaThapNhat());
                    break;

                case MenuCT.Xóa_tất_cả_ấn_phẩm_có_giá_thấp_nhất:
                    Console.WriteLine("Danh sách ấn phẩm trước xóa:\n{0}", ToString());
                    XoaAPGiaThapNhat();
                    Console.WriteLine("Danh sách ấn phẩm sau xóa:\n{0}", ToString());
                    break;

                case MenuCT.Chèn_ấn_phẩm_vào_danh_sách_ấn_phẩm_trước_vị_trí_i:
                    Console.WriteLine(ToString());
                    Console.Write("Nhập vị trí muốn chèn: ");
                    int i = int.Parse(Console.ReadLine());
                    if (i < 0 || i > collection.Count())
                        Console.WriteLine("Vị trí không hợp lệ");
                    else
                    {
                        Console.WriteLine("\nNhập thông tin ấn phẩm: ");
                        Chen(i);
                        Console.WriteLine("Danh sách án phẩm sau khi chèn:\n{0}", ToString());
                    }
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
        public void ChayChuongTrinh()
        {
            MenuCT chon;
            do
            {
                Console.Clear();
                XuatMenu();
                chon = ChonMenu();
                XuLyMenu(chon);
            } while (chon != MenuCT.Thoát_chương_trình);
        }
    }
}
