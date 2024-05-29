using System;
using static System.Console;
using static _2312805_lab1_PhanD.ThuVien;

namespace _2312805_lab1_PhanD
{
    public class Menu
    {
        public enum MenuCT
        {
            Thoat,
            NhapMang,
            NhapTuDong,
            XuatMang,
            PTuLonNhat,
            SoLanXuatHien,
            ThayThe,
            DaoNguoc,
            Xoa,
            SoAmLonNhat,
            TongSoNguyenTo,
            SapTang_2,
            Chen,
            TonTai0Va1,
            SapTang,
        }
        public void XuatMenu()
        {
            WriteLine("=================================MENU=================================");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.Thoat, "thoát");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.NhapMang, "nhập mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.NhapTuDong, "nhập tự động");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.XuatMang, "xuất mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.PTuLonNhat, "tìm phần tử lớn nhất trong mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.SoLanXuatHien, "số lần xuất hiện của phần tử x trong mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.ThayThe, "thay thế phần tử x");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.DaoNguoc, "đảo ngược mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.Xoa, "xóa tất cả phần tử x trong mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.SoAmLonNhat, "tìm số âm lớn nhất đầu tiên trong mảng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.TongSoNguyenTo, "tính tổng các số nguyên tố");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.SapTang_2, "sắp các phần tử sao cho số 0 ở đầu mảng, số âm ở giữa và giảm dần, số dương ở cuối tăng");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.Chen, "chèn phần tử x vào mảng tại 1 vị trí cho trước");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.TonTai0Va1, "kiểm tra mảng có chứa phần tử 0 và 1 hay không? ");
            WriteLine("Nhập {0} để {1}", (int)MenuCT.SapTang, "sắp mảng tăng dần");
            WriteLine("=================================MENU=================================");
        }
        public MenuCT ChonMenu()
        {
            int x;
            do
            {
                Write("Chọn menu {0} <= chọn <= {1}: ", (int)MenuCT.Thoat, (int)MenuCT.SapTang);
                x = Convert.ToInt32(ReadLine());
                if ((int)MenuCT.Thoat <= x && x <= (int)MenuCT.SapTang)
                    break;
            } while (true);
            return (MenuCT)x;
        }
        public void XuLyMenu(MenuCT chon)
        {
            int x, y, z, t;
            ThuVien tv = new ThuVien();

            switch (chon)
            {
                case MenuCT.Thoat:
                    WriteLine("Thoát chương trình!");
                    break;

                case MenuCT.NhapMang:
                    Write("Nhập số phần tử: ");
                    n = Convert.ToInt32(ReadLine());
                    WriteLine("Nhập mảng: ");
                    tv.NhapMang();
                    tv.XuatMang();
                    break;

                case MenuCT.NhapTuDong:
                    Write("Nhập số phần tử: ");
                    n = Convert.ToInt32(ReadLine());
                    tv.NhapTuDong();
                    tv.XuatMang();
                    break;

                case MenuCT.XuatMang:
                    WriteLine("Mảng là: ");
                    tv.XuatMang();
                    break;

                case MenuCT.SapTang:
                    WriteLine("Mảng sắp tăng" + "\nMảng ban đầu: ");
                    tv.XuatMang();
                    WriteLine("\nMảng sau sắp xếp: ");
                    tv.SapTang();
                    tv.XuatMang();
                    break;

                case MenuCT.PTuLonNhat:
                    tv.XuatMang();
                    x = tv.PTuLonNhat();
                    WriteLine("\nPhần tử lớn nhất trong mảng: {0}", x);
                    break;

                case MenuCT.SoLanXuatHien:
                    tv.XuatMang();
                    Write("\nNhập phần tử muốn tính số lần xuất hiện: ");
                    y = Convert.ToInt32(ReadLine());
                    x = tv.SoLanXuatHien(y);
                    WriteLine("\nSố lần xuất hiện của phần tử {0} trong mảng là: {1}", y, x);
                    break;

                case MenuCT.ThayThe:
                    tv.XuatMang();
                    Write("\nNhập phần tử cần thay thế: ");
                    y = Convert.ToInt32(ReadLine());
                    t = tv.Tim(y);
                    if (t != -1)
                    {
                        Write("\nNhập phần tử muốn thay thế: ");
                        z = Convert.ToInt32(ReadLine());
                        tv.ThayThe(y, z);
                        tv.XuatMang();
                    }
                    else
                        Write("\nKhông tồn tại phần tử {0} trong mảng", y);
                    break;

                case MenuCT.DaoNguoc:
                    WriteLine("\nĐảo ngược mảng" + "\nMảng ban đầu là: ");
                    tv.XuatMang();
                    WriteLine("\nMảng sau đảo ngược là: ");
                    tv.DaoNguoc();
                    tv.XuatMang();
                    break;

                case MenuCT.Xoa:
                    WriteLine("Mảng trước khi xóa là: ");
                    tv.XuatMang();
                    Write("\nxóa tất cả phần tử x trong mảng" + "\nNhập phần tử: ");
                    z = Convert.ToInt32(ReadLine());
                    if (tv.TimPTu(z) == -1)
                        Write("\nKhông tồn tại phần tử {0} trong mảng", z);
                    else
                    {
                        tv.Xoa(z);
                        WriteLine("\nMảng sau khi xóa là: ");
                        tv.XuatMang();
                    }
                    break;

                case MenuCT.SoAmLonNhat:
                    WriteLine("Mảng là: ");
                    tv.XuatMang();
                    x = tv.SoAmDau();
                    if (x != 0)
                    {
                        y = tv.SoAm();
                        WriteLine("\nSố âm lớn nhất trong mảng là: " + y);
                    }
                    else
                        WriteLine("\nKhông tồn tại số âm trong mảng");
                    break;

                case MenuCT.TongSoNguyenTo:
                    WriteLine("Mảng là: ");
                    tv.XuatMang();
                    x = tv.SoNguyenTo();
                    if (x == 0)
                        WriteLine("\nKhông tồn tại số nguyên tố trong mảng");
                    else
                        WriteLine("\nTổng số nguyên tố trong mảng là: " + x);
                    break;

                case MenuCT.SapTang_2:
                    WriteLine("Mảng trước sắp xếp là: ");
                    tv.XuatMang();
                    WriteLine("\nSắp các phần tử sao cho số 0 ở đầu mảng, số âm ở giữa và giảm dần, số dương ở cuối tăng");
                    WriteLine("\nMảng sau sắp xếp là: ");
                    tv.SapTang_2();
                    tv.XuatMang();
                    break;

                case MenuCT.Chen:
                    WriteLine("Mảng là: ");
                    tv.XuatMang();
                    Write("\nNhập vị trí muốn chèn {0} <= vị trí <= {1}: ", 0, n - 1);
                    x = Convert.ToInt32(ReadLine());
                    if (0 <= x && x <= n - 1)
                    {
                        tv.Chen(x);
                        WriteLine("Mảng sau khi chèn là: ");
                        tv.XuatMang();
                    }
                    else
                        Write("Vị trí {0} không tồn tại trong mảng", x);
                    break;

                case MenuCT.TonTai0Va1:
                    WriteLine("Mảng là: ");
                    tv.XuatMang();
                    x = tv.TonTai0Hoac1();
                    if (x == 1)
                        WriteLine("\nCó cùng tồn tại 2 chữ số 0 và 1 trong mảng");
                    else
                        WriteLine("\nKhông cùng tồn tại 2 chữ số 0 và 1 trong mảng");
                    break;

                default:
                    break;
            }
            ReadKey();
        }
    }
}