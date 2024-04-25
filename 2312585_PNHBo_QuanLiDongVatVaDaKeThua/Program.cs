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

            Menu menu = new Menu();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================Chon chuc nang======================================");
                Console.WriteLine($"Nhap {(int)ThucDon.NhapTuFile} để đọc từ file ");
                Console.WriteLine($"Nhap {(int)ThucDon.Xuat} để xuất danh sách");
                Console.WriteLine($"Nhap {(int)ThucDon.DemSLDV} để đếm số lượng động vật  Bat, Lion, Bird ");
                Console.WriteLine($"Nhap {(int)ThucDon.DemSLDVBietBayVaKhongBietBay} để đếm số lượng động vật biết bay ");
                Console.WriteLine($"Nhap {(int)ThucDon.DemSLDVBietBayTheoTen} đếm số lượng động vật biết bay theo tên ");
                Console.WriteLine($"Nhap {(int)ThucDon.DemSLDVBietBayTheoTuoi} đếm số lượng động vật biết bay theo tuổi");
                Console.WriteLine($"Nhap {(int)ThucDon.DemSLDVKoBietBayTheoTen} đếm số lượng động vật không biết bay theo tên");
                Console.WriteLine($"Nhap {(int)ThucDon.DemSLDVKoBietBayTheoTuoi} đếm số lượng động vật không biết bay theo tuổi");
                Console.WriteLine($"Nhap {(int)ThucDon.TimDVCoSLItNhat} tìm động vật có số lượng ít nhất");
                Console.WriteLine($"Nhap {(int)ThucDon.TimDVCoSLNhieuNhat} tìm động vật có số lượng nhiều nhất");
                Console.WriteLine($"Nhap {(int)ThucDon.TimALLDVThuocLoai} tìm tất cả động vật thuộc loài Bat, Lion, Bird");
                Console.WriteLine($"Nhap {(int)ThucDon.TimALLDVCoTenNganDaiNhat} tìm tất cả động vật có tên ngắn và dài nhất");
                Console.WriteLine($"Nhap {(int)ThucDon.TimALLDVCoTuoiLonNhoNhat} tìm tất cả động vật có tuổi nhỏ và lớn nhất");
                Console.WriteLine($"Nhap {(int)ThucDon.TimALLDvCoTenNganDaiNhatTheoLoai} tìm tất cả động vật có tên nhỏ và lớn nhất theo loài");
                Console.WriteLine($"Nhap {(int)ThucDon.TimALLDVCoTuoiLonNhoNhatTheoLoai} tìm tất cả động vật có tuổi nhỏ và lớn nhất theo loài");
                Console.WriteLine($"Nhap {(int)ThucDon.TimDSCacDVBietBay} để tìm danh sách các động vật biết bay");
                Console.WriteLine($"Nhap {(int)ThucDon.TimDSCacDVKoBietBay} để tìm danh sách các động vật không biết bay");
                Console.WriteLine($"Nhap {(int)ThucDon.Thoat} de thoat");
                Console.WriteLine("=========================================================================================");
                Console.Write("Nhap so Menu : ");
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
                        Console.WriteLine("Số lượng Bat là : " + ds.DemSLBat());
                        Console.WriteLine("Số lượng Lion là : " + ds.DemSLLion());
                        Console.WriteLine("Số lượng Bird là : " + ds.DemSLBird());
                        break;
                    case ThucDon.DemSLDVBietBayVaKhongBietBay:
                        Console.WriteLine("Đếm số lượng động vật biết bay, không biết bay");
                        Console.WriteLine("Số lượng động vật biết bay là : " + ds.DemSLDongVatBietBay());
                        Console.WriteLine("Số lượng động vật không biết bay là : " + ds.DemSLDongVatKhongBietBay());
                        break;
                    case ThucDon.DemSLDVBietBayTheoTen:
                        Console.WriteLine("Đếm số lượng động vật biết bay theo tên ");
                        ds.Xuat();
                        Console.WriteLine("Nhập tên động vật cần đếm : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Số lượng động vật tên " + name + " là : " + ds.DemSLDVBietBayTheoTen(name));  
                        break;
                    case  ThucDon.DemSLDVBietBayTheoTuoi:
                        Console.WriteLine("Đếm số lượng động vật biết bay theo tuổi ");
                        ds.Xuat();
                        Console.WriteLine("Nhập tuổi động vật cần đếm : ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng động vật có tuổi " + age +" là : " + ds.DemSLDVBietBayTheoTuoi(age));
                        break;
                    case ThucDon.DemSLDVKoBietBayTheoTen:
                        Console.WriteLine("Đếm số lượng động vật không biết bay theo tên ");
                        ds.Xuat();
                        Console.WriteLine("Nhập tên động vật cần đếm : ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Số lượng động vật tên " + name1 + " là : " + ds.DemSLDVBietBayTheoTen(name1));
                        break;
                    case ThucDon.DemSLDVKoBietBayTheoTuoi:
                        Console.WriteLine("Đếm số lượng động vật không biết bay theo tuổi ");
                        ds.Xuat();
                        Console.WriteLine("Nhập tuổi động vật cần đếm : ");
                        int age1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng động vật có tuổi " + age1 + " là : " + ds.DemSLDVBietBayTheoTuoi(age1));
                        break;
                    case ThucDon.TimALLDVThuocLoai:
                        Console.WriteLine("Tìm tất cả động vật thuộc loài Bat, Lion, Bird ");
                        Console.WriteLine("Tim tất cả động vật thuộc loài Bat : " );
                        List<IAnimal> kq = ds.TimALLDVThuocBat();
                        foreach ( var item in kq)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tim tất cả động vật thuộc loài Lion : "  );
                        List<IAnimal> kq1 = ds.TimALLDVThuocLion();
                        foreach (var item in kq1)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tim tất cả động vật thuộc loài Bird : "  );
                        
                        List<IAnimal> kq2 = ds.TimALLDVThuocBird();
                        foreach (var item in kq2)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case ThucDon.TimALLDVCoTenNganDaiNhat:
                        Console.WriteLine("Tìm tất cả động vật có tên ngắn nhất, dài nhất");
                        Console.WriteLine("Tìm tất cả động vật có tên ngắn nhất : ");
                        List<IAnimal> kq3 = ds.TimALLDVCoTenNganNhat();
                        foreach (var item in kq3)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Tìm tất cả động vật có tên dài nhất : ");
                        List<IAnimal> kq4 = ds.TimALLDVCoTenDaiNhat();
                        foreach (var item in kq4)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case ThucDon.TimALLDVCoTuoiLonNhoNhat:
                        Console.WriteLine("Tìm tất cả động vật có tuổi ngắn nhất, dài nhất");
                        Console.WriteLine("Tìm tất cả động vật có tuổi ngắn nhất : ");
                        List<IAnimal> kq5 = ds.TimALLDVCoTuoiMAX();
                        foreach (var item in kq5)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Tìm tất cả động vật có tuổi dài nhất : ");
                        List<IAnimal> kq6 = ds.TimALLDVCoTuoiMIN();
                        foreach (var item in kq6)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case ThucDon.TimALLDvCoTenNganDaiNhatTheoLoai:
                        Console.WriteLine("Tìm tất cả động vật có tên ngắn và dài nhất theo loài");
                        Console.WriteLine("Tìm tất cả động vật có tên ngắn nhất theo loài : ");
                        Console.WriteLine("Nhập tên loài : ");
                        string kind = Console.ReadLine();
                        List<IAnimal> kq7 = ds.TimDVCoTenNganNhatTheoLoai(kind);
                        foreach (var item in kq7)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Tìm tất cả động vật có tên dài nhất theo loài : ");
                        Console.WriteLine("Nhập tên loài : ");
                        string kind1 = Console.ReadLine();
                        List<IAnimal> kq8 = ds.TimDVCoTenDaiNhatTheoLoai(kind1);
                        foreach (var item in kq8)
                        {
                            Console.WriteLine(item);
                        }
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
            TimALLDvCoTenNganDaiNhatTheoLoai,
            TimALLDVCoTuoiLonNhoNhatTheoLoai,
            TimDSCacDVBietBay,
            TimDSCacDVKoBietBay,
            Thoat,

           
        }

    }
}

