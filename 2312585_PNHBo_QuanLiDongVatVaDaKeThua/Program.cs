using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLiDongVatVaDaKeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyDongVat ds = new QuanLyDongVat();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================== CHỌN CHỨC NĂNG ======================================");
                Console.WriteLine($"Nhập {(int)ThucDon.NhapTuFile} để nhập từ File");
                Console.WriteLine($"Nhập {(int)ThucDon.Xuat} để xuất danh sách động vật");
                Console.WriteLine($"Nhập {(int)ThucDon.DemSLDV} để đếm số lượng động vật");
                Console.WriteLine($"Nhập {(int)ThucDon.DemSLDVBietBayVaKhongBietBay} để đếm số lượng động vật biết bay và không biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.DemSLDVBietBayTheoTen} để đếm số lượng động vật biết bay theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.DemSLDVBietBayTheoTuoi} để đếm số lượng động vật biết bay theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.DemSLDVKoBietBayTheoTen} để đếm số lượng động vật không biết bay theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.DemSLDVKoBietBayTheoTuoi} để đếm số lượng động vật không biết bay theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.TimDVCoSLItNhat} để tìm loài động vật có số lượng ít nhất");
                Console.WriteLine($"Nhập {(int)ThucDon.TimDVCoSLNhieuNhat} để tìm loài động vậy có số lượng nhiều nhất");
                Console.WriteLine($"Nhập {(int)ThucDon.TimALLDVThuocLoai} để tìm all loài Bat, Lion, Bird");
                Console.WriteLine($"Nhập {(int)ThucDon.TimALLDVCoTenNganDaiNhat} để tìm all động vật có tên ngắn, dài nhất");
                Console.WriteLine($"Nhập {(int)ThucDon.TimALLDVCoTuoiLonNhoNhat} để tìm all động vật có tuổi lớn, nhỏ nhất");
                Console.WriteLine($"Nhập {(int)ThucDon.TimALLDVCoTenNganDaiNhatTheoLoai} để tìm all động vật có tên ngắn, dài nhất theo loài");
                Console.WriteLine($"Nhập {(int)ThucDon.TimALLDVCoTuoiLonNhoNhatTheoLoai} để tìm all động vật có tuổi nhỏ, lớn nhất theo loài");
                Console.WriteLine($"Nhập {(int)ThucDon.TimDSCacDVBietBay} để tìm danh sách các động vật biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.TimDSCacDVKoBietBay} để tìm danh sách các động vật không biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.SapXepTangTheoTen_Tuoi} để sắp xếp tăng theo tên, tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.SapXepGiamTheoTen_Tuoi} để sắp xếp giảm theo tên, tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaALLDVTheoLoai} để xóa all động vật theo loài Bat, Lion, Bird");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaALLDVBietBay} để xóa all động vật biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaALLDVKoBietBay} để xóa all động vật không biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatBietBayTheoTen} để xóa all động vật biết bay theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatBietBayTheoTuoi} để xóa all động vật biết bay theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatKhongBietBayTheoTen} để xóa all động vật không biết bay theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatKhongBietBayTheoTuoi} để xóa all động vật không biết bay theo tuổi ");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatCoTuoiNhoNhat} để xóa all động vật có tuổi nhỏ nhất");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatCoTuoiLonNhat} để xóa all động vật có tuổi lớn nhất");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatCoTuoiLonNhatTheoLoai} để xóa all động vật có tuổi lớn nhất theo loài");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatCoTuoiNhoNhatTheoLoai} để xóa all động vật có tuổi nhỏ nhất theo loài");
                Console.WriteLine($"Nhập {(int)ThucDon.XoaAllDongVatTaiViTriX} để xóa all động vật tại vị trí X ");
                Console.WriteLine($"Nhập {(int)ThucDon.TinhTongTuoiDongVatTheoLoai} để tính tổng tuổi động vật theo loài");
                Console.WriteLine($"Nhập {(int)ThucDon.TinhTongTuoiDongVatBietBay} để tính tổng tuổi động vật biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.TinhTongTuoiDongVatKoBietBay} để tính tổng tuổi động vật không biết bay");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSTangTen} để hiển thị danh sách tăng theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSGiamTen} để hiển thị danh sách giảm theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSGiamTuoi} để hiển thị danh sách giảm theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSTangTuoi} để hiển thị danh sách tăng theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSBat} để hiển thị danh sách loài Bat");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSLion} để hiển thị danh sách loài Lion");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSBird} để hiển thị danh sách loài Bird");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSBatTangTheoTen} để hiển thị danh sách loài Bat tăng theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSBatGiamTheoTen} để hiển thị danh sách loài Bat giảm theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSBatTangTheoTuoi} để hiển thị danh sách loài Bat tăng theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSBatGiamTheoTuoi} để hiển thị danh sách loài Bat giảm theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienTHiDSLionTangTheoTen} để hiển thị danh sách loài Lion tăng theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSLionGiamTheoTen} để hiển thị danh sách loài Lion giảm theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSLionTangTheoTuoi} để hiển thị danh sách loài Lion tăng theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDSLionGiamTheoTuoi} để hiển thị danh sách loài Lion giảm theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDsBirdTangTheoTen} để hiển thị danh sách loài Bird tăng theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDsBirdGiamTheoTen} để hiển thị danh sách loài Bird giảm theo tên");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDsBirdTangTheoTuoi} để hiện thị danh sách loài Bird tăng theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.HienThiDsBirdGiamTheoTuoi} để hiển thị danh sách loài Bird giảm theo tuổi");
                Console.WriteLine($"Nhập {(int)ThucDon.XuatFile} để xuất file");
                Console.WriteLine($"Nhập {(int)ThucDon.Thoat} để thoát");
                Console.WriteLine("===========================================================================================");
                Console.Write("Nhập số Menu : ");
                ThucDon chon = (ThucDon)int.Parse(Console.ReadLine());

                switch (chon)
                {

                    case ThucDon.NhapTuFile:
                        ds.DocFile("data.txt");
                        break;
                    case ThucDon.Xuat:
                        ds.Xuat();
                        break;
                    case ThucDon.DemSLDV:
                        Console.WriteLine("Đếm số lượng động vật là Bat, Lion, Bird");
                        Console.WriteLine("Số lượng Bat là : " + ds.DemSLTheoLoai(LoaiDongVat.Bat));
                        Console.WriteLine("Số lượng Lion là : " + ds.DemSLTheoLoai(LoaiDongVat.Lion));
                        Console.WriteLine("Số lượng Bird là : " + ds.DemSLTheoLoai(LoaiDongVat.Bird));
                        break;
                    case ThucDon.DemSLDVBietBayVaKhongBietBay:
                        Console.WriteLine("Đếm số lượng động vật biết bay, không biết bay");
                        Console.WriteLine("Số lượng động vật biết bay là : " + ds.DemSLTheoLoai(Fly.Flyable));
                        Console.WriteLine("Số lượng động vật không biết bay là : " + ds.DemSLTheoLoai(Fly.Unflyable));
                        break;
                    case ThucDon.DemSLDVBietBayTheoTen:
                        Console.WriteLine("Đếm số lượng động vật biết bay theo tên ");
                        ds.DSDVBietBay().Xuat();
                        Console.Write("Nhập tên động vật cần đếm : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Số lượng động vật tên " + name + " là : " + ds.DemSLDVBietBayTheoTen(name));
                        break;
                    case ThucDon.DemSLDVBietBayTheoTuoi:
                        Console.WriteLine("Đếm số lượng động vật biết bay theo tuổi ");
                        ds.DSDVBietBay().Xuat();
                        Console.Write("Nhập tuổi động vật cần đếm : ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng động vật có tuổi " + age + " là : " + ds.DemSLDVBietBayTheoTuoi(age));
                        break;
                    case ThucDon.DemSLDVKoBietBayTheoTen:
                        Console.WriteLine("Đếm số lượng động vật không biết bay theo tên ");
                        ds.DSDVKoBietBay().Xuat();
                        Console.Write("Nhập tên động vật cần đếm : ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Số lượng động vật tên " + name1 + " là : " + ds.DemSLDVKhongBietBayTheoTen(name1));
                        break;
                    case ThucDon.DemSLDVKoBietBayTheoTuoi:
                        Console.WriteLine("Đếm số lượng động vật không biết bay theo tuổi ");
                        ds.DSDVKoBietBay().Xuat();
                        Console.Write("Nhập tuổi động vật cần đếm : ");
                        int age1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng động vật có tuổi " + age1 + " là : " + ds.DemSLDVKhongBietBayTheoTuoi(age1));
                        break;
                    case ThucDon.TimALLDVThuocLoai:
                        Console.WriteLine("Tìm tất cả động vật thuộc loài Bat, Lion, Bird ");
                        Console.WriteLine("Danh sách loài Bird: ");
                        Console.WriteLine(ds.TimDSDVTheoLoai(LoaiDongVat.Bird));
                        Console.WriteLine("Danh sách loài Lion: ");
                        Console.WriteLine(ds.TimDSDVTheoLoai(LoaiDongVat.Lion));
                        Console.WriteLine("Danh sách loài Bat: ");
                        Console.WriteLine(ds.TimDSDVTheoLoai(LoaiDongVat.Bat));
                        break;

                    case ThucDon.TimALLDVCoTenNganDaiNhat:
                        Console.WriteLine("Tìm tất cả động vật có tên ngắn nhất : ");
                        ds.TimALLDVCoTen_Min().Xuat();
                        Console.WriteLine("Tìm tất cả động vật có tên dài nhất : ");
                        ds.TimALLDVCoTen_Max().Xuat();
                        break;
                    case ThucDon.TimALLDVCoTuoiLonNhoNhat:
                        Console.WriteLine("Tìm tất cả động vật có tuổi ngắn nhất  ");
                        ds.TimALLDVCoTuoi_Min().Xuat();
                        Console.WriteLine("Tìm tất cả động vật có tuổi dài nhất  ");
                        ds.TimALLDVCoTuoi_Max().Xuat();
                        break;
                    case ThucDon.TimALLDVCoTenNganDaiNhatTheoLoai:
                        Console.WriteLine("Tìm tất cả động vật có tên ngắn và dài nhất theo loài (Bat, Lion, Bird)");
                        Console.WriteLine("Động vật có tên ngắn nhất của loài Bat");
                        ds.TimDVCoTenNganNhatTheoLoai(LoaiDongVat.Bat).Xuat();
                        Console.WriteLine("Động vật có tên dài nhất của loài Bat");
                        ds.TimDVCoTenDaiNhatTheoLoai(LoaiDongVat.Bat).Xuat();
                        Console.WriteLine("Động vật có tên ngắn nhất theo loài Lion");
                        ds.TimDVCoTenNganNhatTheoLoai(LoaiDongVat.Lion).Xuat();
                        Console.WriteLine("Động vật có tên dài nhất theo loài Lion");
                        ds.TimDVCoTenDaiNhatTheoLoai(LoaiDongVat.Lion).Xuat();
                        Console.WriteLine("Động vật có tên ngắn nhất theo loài Bird");
                        ds.TimDVCoTenNganNhatTheoLoai(LoaiDongVat.Bird).Xuat();
                        Console.WriteLine("Động vật có tên dài nhất theo loài Bird");
                        ds.TimDVCoTenDaiNhatTheoLoai(LoaiDongVat.Bird).Xuat();
                        break;
                    case ThucDon.TimDVCoSLItNhat:
                        Console.WriteLine("Tìm loài động vật có số lượng ít nhất");
                        ds.TimDongVatSL_Min();
                        break;
                    case ThucDon.TimDVCoSLNhieuNhat:
                        Console.WriteLine("Tìm loài động vật có số lượng ít nhất");
                        ds.TimDongVatSL_Max();
                        break;
                    case ThucDon.TimALLDVCoTuoiLonNhoNhatTheoLoai:
                        Console.WriteLine("Tìm loài động vật có tuổi lớn nhất theo loài");
                        ds.TimDVCoTuoiLonNhatTheoLoai(LoaiDongVat.Bat).Xuat();
                        ds.TimDVCoTuoiLonNhatTheoLoai(LoaiDongVat.Lion).Xuat();
                        ds.TimDVCoTuoiLonNhatTheoLoai(LoaiDongVat.Bird).Xuat();
                        Console.WriteLine("Tìm loài động vật có tuổi nhỏ nhất theo loài");
                        ds.TimDVCoTuoiNhoNhatTheoLoai(LoaiDongVat.Bat).Xuat();
                        ds.TimDVCoTuoiNhoNhatTheoLoai(LoaiDongVat.Lion).Xuat();
                        ds.TimDVCoTuoiNhoNhatTheoLoai(LoaiDongVat.Bird).Xuat();
                        break;
                    case ThucDon.TimDSCacDVBietBay:
                        Console.WriteLine("Danh sách các động vật biết bay : ");
                        ds.DSDVBietBay().Xuat();
                        break;
                    case ThucDon.TimDSCacDVKoBietBay:
                        Console.WriteLine("Danh sách các động vật không biết bay : ");
                        ds.DSDVKoBietBay().Xuat();
                        break;
                    case ThucDon.XuatFile:
                        ds.XuatFile();
                        break;
                    case ThucDon.SapXepTangTheoTen_Tuoi:
                        Console.WriteLine("Sắp xếp tăng theo tên tuổi");
                        ds.SapXepDVTangTheoTuoi().SapXepDVTangTheoTen().Xuat();
                        break;
                    case ThucDon.SapXepGiamTheoTen_Tuoi:
                        Console.WriteLine("Sắp xếp giảm theo tên tuổi");
                        ds.SapXepDVGiamTheoTuoi().SapXepDVGiamTheoTen().Xuat();
                        break;
                    case ThucDon.XoaALLDVTheoLoai:
                        Console.WriteLine("Xóa tất cả động vật theo loài");
                        Console.Write("Nhập loài động vật cần xóa (Bat, Lion, Bird): ");
                        LoaiDongVat loai = (LoaiDongVat)Enum.Parse(typeof(LoaiDongVat), Console.ReadLine());
                        ds.XoaDVGiDo(loai).Xuat();
                        break;
                    case ThucDon.XoaALLDVBietBay:
                        Console.WriteLine("Xóa tất cả động vật biết bay");
                        ds.XoaAllDongVatBietBay(Fly.Flyable);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaALLDVKoBietBay:
                        Console.WriteLine("Xóa tất cả động vật không biết bay");
                        ds.XoaAllDongVatKhongBietBay(Fly.Unflyable);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaAllDongVatCoTuoiNhoNhat:
                        Console.WriteLine("Xóa tất cả động vật có tuổi nhỏ nhất");
                        ds.XoaAllDongVatCoTuoiNhoNhat();
                        ds.Xuat();
                        break;
                    case ThucDon.XoaAllDongVatCoTuoiLonNhat:
                        Console.WriteLine("Xóa tất cả động vật có tuổi lớn nhất");
                        ds.XoaAllDongVatCoTuoiLonNhat();
                        ds.Xuat();

                        break;
                    case ThucDon.XoaAllDongVatCoTuoiLonNhatTheoLoai:
                        Console.WriteLine("Xóa tất cả động vật có tuổi lớn nhất theo loài " + LoaiDongVat.Bat);
                        ds.XoaAllDongVatCoTuoiLonNhatTheoLoai(LoaiDongVat.Bat);
                        ds.XuatTheoLoai(LoaiDongVat.Bat);
                        Console.WriteLine("Xóa tất cả động vật có tuổi lớn nhất theo loài " + LoaiDongVat.Lion);
                        ds.XoaAllDongVatCoTuoiLonNhatTheoLoai(LoaiDongVat.Lion);
                        ds.XuatTheoLoai(LoaiDongVat.Lion);
                        Console.WriteLine("Xóa tất cả động vật có tuổi lớn nhất theo loài " + LoaiDongVat.Bird);
                        ds.XoaAllDongVatCoTuoiLonNhatTheoLoai(LoaiDongVat.Bird);
                        ds.XuatTheoLoai(LoaiDongVat.Bird);
                        break;
                    case ThucDon.XoaAllDongVatCoTuoiNhoNhatTheoLoai:
                        Console.WriteLine("Xóa tất cả động vật có tuổi nhỏ nhất theo loài " + LoaiDongVat.Bat);
                        ds.XoaAllDongVatCoTuoiNhoNhatTheoLoai(LoaiDongVat.Bat);
                        ds.XuatTheoLoai(LoaiDongVat.Bat);
                        Console.WriteLine("Xóa tất cả động vật có tuổi nhỏ nhất theo loài " + LoaiDongVat.Lion);
                        ds.XoaAllDongVatCoTuoiNhoNhatTheoLoai(LoaiDongVat.Lion);
                        ds.XuatTheoLoai(LoaiDongVat.Lion);
                        Console.WriteLine("Xóa tất cả động vật có tuổi nhỏ nhất theo loài " + LoaiDongVat.Bird);
                        ds.XoaAllDongVatCoTuoiNhoNhatTheoLoai(LoaiDongVat.Bird);
                        ds.XuatTheoLoai(LoaiDongVat.Bird);
                        break;
                    case ThucDon.XoaAllDongVatTaiViTriX:
                        ds.Xuat();
                        Console.WriteLine("Xóa tất cả động vật tại vị trí x");
                        Console.Write("Nhập vị trí x cần xóa : ");
                        int x = int.Parse(Console.ReadLine());
                        ds.XoaAllDongVatTaiViTriX(x - 1);
                        ds.Xuat();
                        break;
                    case ThucDon.TinhTongTuoiDongVatTheoLoai:
                        Console.WriteLine("Tính tổng tuổi của các động vật theo loài");
                        Console.WriteLine("Tổng tuổi của loài Bat là : " + ds.TinhTongTuoiDongVatTheoLoai(LoaiDongVat.Bat));
                        Console.WriteLine("Tổng tuổi của loài Lion là : " + ds.TinhTongTuoiDongVatTheoLoai(LoaiDongVat.Lion));
                        Console.WriteLine("Tổng tuổi của loài Bird là : " + ds.TinhTongTuoiDongVatTheoLoai(LoaiDongVat.Bird));
                        break;
                    case ThucDon.TinhTongTuoiDongVatBietBay:
                        ds.DSDVBietBay().Xuat();
                        Console.WriteLine("Tính tổng tuổi của các động vật biết bay là :" + ds.TinhTongTuoiDongVatBietBay_KoBietBay(Fly.Flyable));
                        break;
                    case ThucDon.TinhTongTuoiDongVatKoBietBay:
                        ds.DSDVKoBietBay().Xuat();
                        Console.WriteLine("Tính tổng tuổi của các động vật không biết bay là :" + ds.TinhTongTuoiDongVatBietBay_KoBietBay(Fly.Unflyable));
                        break;
                    case ThucDon.HienThiDSTangTen:
                        Console.WriteLine("Hiển thị danh sách tăng theo tên (A-Z) : ");
                        ds.HienThiDSTangGiamCuaTenTuoi(Sort.TangName).Xuat();
                        break;
                    case ThucDon.HienThiDSGiamTen:
                        Console.WriteLine("Hiển thị danh sách giảm theo tên (Z-A) : ");
                        ds.HienThiDSTangGiamCuaTenTuoi(Sort.GiamName).Xuat();
                        break;
                    case ThucDon.HienThiDSGiamTuoi:
                        Console.WriteLine("Hiển thị danh sách giảm theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoi(Sort.GiamAge).Xuat();
                        break;
                    case ThucDon.HienThiDSTangTuoi:
                        Console.WriteLine("Hiển thị danh sách tăng theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoi(Sort.TangAge).Xuat();
                        break;
                    case ThucDon.HienThiDSBat:
                        Console.WriteLine("Hiển thị danh sách Bat : ");
                        ds.XuatTheoLoai(LoaiDongVat.Bat);
                        break;
                    case ThucDon.HienThiDSLion:
                        Console.WriteLine("Hiển thị danh sách Lion : ");
                        ds.XuatTheoLoai(LoaiDongVat.Lion);
                        break;
                    case ThucDon.HienThiDSBird:
                        Console.WriteLine("Hiển thị danh sách Bird : ");
                        ds.XuatTheoLoai(LoaiDongVat.Bird);
                        break;
                    case ThucDon.HienThiDSBatTangTheoTen:
                        Console.WriteLine("Hiển thị danh sách Bat tăng theo tên : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bat, Sort.TangName);
                        break;
                    case ThucDon.HienThiDSBatGiamTheoTen:
                        Console.WriteLine("Hiển thị danh sách Bat giảm theo tên : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bat, Sort.GiamName);
                        break;
                    case ThucDon.HienThiDSBatTangTheoTuoi:
                        Console.WriteLine("Hiển thị danh sách Bat tăng theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bat, Sort.TangAge);
                        break;
                    case ThucDon.HienThiDSBatGiamTheoTuoi:
                        Console.WriteLine("Hiển thị danh sách Bat giảm theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bat, Sort.GiamAge);
                        break;
                    case ThucDon.HienTHiDSLionTangTheoTen:
                        Console.WriteLine("Hiển thị danh sách Lion tăng theo tên : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Lion, Sort.TangName);
                        break;
                    case ThucDon.HienThiDSLionGiamTheoTen:
                        Console.WriteLine("Hiển thị danh sách Lion giảm theo tên : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Lion, Sort.GiamName);
                        break;
                    case ThucDon.HienThiDSLionTangTheoTuoi:
                        Console.WriteLine("Hiển thị danh sách Lion tăng theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Lion, Sort.TangAge);
                        break;
                    case ThucDon.HienThiDSLionGiamTheoTuoi:
                        Console.WriteLine("Hiển thị danh sách Lion giảm theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Lion, Sort.GiamAge);
                        break;
                    case ThucDon.HienThiDsBirdTangTheoTen:
                        Console.WriteLine("Hiển thị danh sách Bird tăng theo tên : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bird, Sort.TangName);
                        break;
                    case ThucDon.HienThiDsBirdGiamTheoTen:
                        Console.WriteLine("Hiển thị danh sách Bird giảm theo tên : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bird, Sort.GiamName);
                        break;
                    case ThucDon.HienThiDsBirdTangTheoTuoi:
                        Console.WriteLine("Hiển thị danh sách Bird tăng theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bird, Sort.TangAge);
                        break;
                    case ThucDon.HienThiDsBirdGiamTheoTuoi:
                        Console.WriteLine("Hiển thị danh sách Bird giảm theo tuổi : ");
                        ds.HienThiDSTangGiamCuaTenTuoiTheoLoai(LoaiDongVat.Bird, Sort.GiamAge);
                        break;
                    case ThucDon.XoaAllDongVatBietBayTheoTen:
                        ds.Xuat();
                        Console.WriteLine("Xóa tất cả động vật biết bay theo tên ");
                        Console.Write("Nhập tên động vật cần xóa : ");
                        string name2 = Console.ReadLine();
                        ds.XoaAllDongVatBietBayTheoTen(name2);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaAllDongVatBietBayTheoTuoi:
                        ds.Xuat();
                        Console.WriteLine("Xóa tất cả động vật biết bay theo tuổi ");
                        Console.Write("Nhập tuổi động vật còn xóa : ");
                        int age2 = int.Parse(Console.ReadLine());
                        ds.XoaAllDongVatBietBayTheoTuoi(age2);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaAllDongVatKhongBietBayTheoTen:
                        ds.Xuat();
                        Console.WriteLine("Xóa tất cả động vật không biết bay theo tên ");
                        Console.Write("Nhập tên động vật cần xóa : ");
                        string name3 = Console.ReadLine();
                        ds.XoaAllDongVatKhongBietBayTheoTen(name3);
                        ds.Xuat();
                        break;
                    case ThucDon.XoaAllDongVatKhongBietBayTheoTuoi:
                        ds.Xuat();
                        Console.WriteLine("Xóa tất cả động vật không biết bay theo tuổi ");
                        Console.Write("Nhập tuổi động vật cần xóa : ");
                        int age3 = int.Parse(Console.ReadLine());
                        ds.XoaAllDongVatKhongBietBayTheoTuoi(age3);
                        ds.Xuat();
                        break;
                    default:
                    case ThucDon.Thoat:
                        return;
                }
                Console.WriteLine("Nhap 1 phim de tiep tuc ");
                Console.ReadKey();
            }
        }

        public enum ThucDon
        {
            NhapTuFile = 1,
            Xuat,
            DemSLDV,
            DemSLDVBietBayVaKhongBietBay,
            DemSLDVBietBayTheoTen,
            DemSLDVBietBayTheoTuoi,
            DemSLDVKoBietBayTheoTen,
            DemSLDVKoBietBayTheoTuoi,
            TimDVCoSLItNhat,
            TimDVCoSLNhieuNhat,
            TimALLDVThuocLoai,
            TimALLDVCoTenNganDaiNhat,
            TimALLDVCoTuoiLonNhoNhat,
            TimALLDVCoTenNganDaiNhatTheoLoai,
            TimALLDVCoTuoiLonNhoNhatTheoLoai,
            TimDSCacDVBietBay,
            TimDSCacDVKoBietBay,
            SapXepTangTheoTen_Tuoi,
            SapXepGiamTheoTen_Tuoi,
            XoaALLDVTheoLoai,
            XoaALLDVBietBay,
            XoaALLDVKoBietBay,
            XoaAllDongVatBietBayTheoTen,
            XoaAllDongVatBietBayTheoTuoi,
            XoaAllDongVatKhongBietBayTheoTen,
            XoaAllDongVatKhongBietBayTheoTuoi,
            XoaAllDongVatCoTuoiNhoNhat,
            XoaAllDongVatCoTuoiLonNhat,
            XoaAllDongVatCoTuoiLonNhatTheoLoai,
            XoaAllDongVatCoTuoiNhoNhatTheoLoai,
            XoaAllDongVatTaiViTriX,
            TinhTongTuoiDongVatTheoLoai,
            TinhTongTuoiDongVatBietBay,
            TinhTongTuoiDongVatKoBietBay,
            HienThiDSTangTen,
            HienThiDSGiamTen,
            HienThiDSGiamTuoi,
            HienThiDSTangTuoi,
            HienThiDSBat,
            HienThiDSLion,
            HienThiDSBird,
            HienThiDSBatTangTheoTen,
            HienThiDSBatGiamTheoTen,
            HienThiDSBatTangTheoTuoi,
            HienThiDSBatGiamTheoTuoi,
            HienTHiDSLionTangTheoTen,
            HienThiDSLionGiamTheoTen,
            HienThiDSLionTangTheoTuoi,
            HienThiDSLionGiamTheoTuoi,
            HienThiDsBirdTangTheoTen,
            HienThiDsBirdGiamTheoTen,
            HienThiDsBirdTangTheoTuoi,
            HienThiDsBirdGiamTheoTuoi,
            XuatFile,
            Thoat = 0,
        }

    }
}

