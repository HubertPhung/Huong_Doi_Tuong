using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_Lab7_TinhKeThuaVaDaKeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachPhuongTien ds = new DanhSachPhuongTien();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================== CHỌN CHỨC NĂNG ======================================");

                Console.WriteLine($"Nhập {(int)ThucDon.Thoat} để thoát");
                Console.WriteLine("===========================================================================================");
                Console.Write("Nhập số Menu : ");
                ThucDon chon = (ThucDon)int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case ThucDon.NhapTuFile:
                        ds.NhapTuFile("data.txt");
                        break;
                    case ThucDon.Xuat:
                        ds.Xuat();
                        break;
                    case ThucDon.DemSoLuongPhuongTienCar:
                        Console.WriteLine("Số lượng của phương tiện Car là : " + ds.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Car));
                        break;
                    case ThucDon.DemSoLuongPhuongTienMotorcycle:
                        Console.WriteLine("Số lượng của phương tiện Motorcycle : " + ds.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.Motorcycle));
                        break;
                    case ThucDon.DemSoLuongPhuongTienCarAndMotorcycle:
                        Console.WriteLine("Số lượng của phương tiện Car và Motorcycle : " + ds.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.CarAndMotorcycle));
                        break;
                    case ThucDon.DemSoLuongPhuongTienCarOrMotorcycle:
                        Console.WriteLine("Số lượng của phương tiện Car hoặc Motorcycle : " + ds.DemSoLuongTheoLoaiPhuongTien(LoaiPhuongTien.CarOrMotorcycle));
                        break;
                    case ThucDon.DemSoLuongDemSoLuongTheoTen:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo tên ");
                        Console.Write("Nhập tên cần đếm : ");
                        string ten = Console.ReadLine();
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoTen(ten));
                        break;
                    case ThucDon.DemSoLuongTheoChoNgoi:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo số chỗ ngồi ");
                        Console.Write("Nhập số chỗ ngồi cần đếm : ");
                        int soChoNgoi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoChoNgoi(soChoNgoi));
                        break;
                    case ThucDon.DemSoLuongTheoTocDo:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo tốc độ ");
                        Console.Write("Nhập số tốc độ cần đếm : ");
                        int tocDo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoTocDo(tocDo));
                        break;
                    case ThucDon.DemSoLuongTheoTenVaSoChoNgoi:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo tên và chỗ ngồi ");
                        Console.WriteLine("Nhập tên cần đếm ");
                        string ten1 = Console.ReadLine();
                        Console.Write("Nhập số chỗ ngồi cần đếm : ");
                        int soChoNgoi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoTenVaSoChoNgoi(ten1, soChoNgoi1));
                        break;
                    case ThucDon.DemSoLuongTheoTenVaTocDo:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo tên và chỗ ngồi ");
                        Console.Write("Nhập tên cần đếm :");
                        string ten2 = Console.ReadLine();
                        Console.Write("Nhập số tốc độ cần đếm : ");
                        int tocDo2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoTenVaTocDo(ten2, tocDo2));
                        break;
                    case ThucDon.DemSoLuongTheoSoChoNgoiVaTocDo:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo số chỗ ngồi và tốc độ ");
                        Console.Write("Nhập số chỗ ngồi cần đếm :");
                        int soChoNgoi3 = int.Parse(Console.ReadLine());
                        Console.Write("Nhập số tốc độ cần đếm : ");
                        int tocDo3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoSoChoNgoiVaTocDo(soChoNgoi3, tocDo3));
                        break;
                    case ThucDon.DemSoLuongTheoTenVaSoChoNgoivaTocDo:
                        ds.Xuat();
                        Console.WriteLine("Đếm số lượng theo tên, số chỗ ngồi và tốc độ ");
                        Console.Write("Nhập tên cần đếm :");
                        string ten4 = Console.ReadLine();
                        Console.Write("Nhập số chỗ ngồi cần đếm : ");
                        int soChoNgoi4 = int.Parse(Console.ReadLine());
                        Console.Write("Nhập số tốc độ cần đếm : ");
                        int tocDo4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Số lượng là : " + ds.DemSoLuongTheoTenVaSoChoNgoivaTocDo(ten4, soChoNgoi4, tocDo4));
                        break;
                    case ThucDon.DemSoLuongTenDaiNhat:
                        Console.WriteLine("Đếm số lượng tên dài nhất là : " + ds.DemSoLuongTenDaiNhat());
                        break;
                    case ThucDon.DemSoLuongTenNganNhat:
                        Console.WriteLine("Đếm số lượng tên ngắn nhất là : " + ds.DemSoLuongTenNganNhat());
                        break;
                    case ThucDon.DemSoLuongChoNgoiLonNhat:
                        Console.WriteLine("Đếm số lượng chỗ ngồi lớn nhất là : " + ds.DemSoLuongChoNgoiLonNhat());
                        break;
                    case ThucDon.DemSoLuongChoNgoiNhoNhat:
                        Console.WriteLine("Đếm số lượng chỗ ngồi nhỏ nhất là : " + ds.DemSoLuongChoNgoiNhoNhat());
                        break;
                    case ThucDon.DemSoLuongTocDoLonNhat:
                        Console.WriteLine("Đếm số lượng tốc độ lớn nhất là : " + ds.DemSoLuongTocDoLonNhat());
                        break;
                    case ThucDon.DemSoLuongTocDoNhoNhat:
                        Console.WriteLine("Đếm số lượng tốc độ nhỏ nhất là : " + ds.DemSoLuongTocDoNhoNhat());
                        break;
                    case ThucDon.TimDSPhuongTienCar:
                        Console.WriteLine("Tìm danh sách phương tiện là Car !");
                        ds.TimDSPhuongTien(LoaiPhuongTien.Car).Xuat();
                        break;
                    case ThucDon.TimDSPhuongTienMotorcycle:
                        Console.WriteLine("Tìm danh sách phương tiện là Motorcycle !");
                        ds.TimDSPhuongTien(LoaiPhuongTien.Motorcycle).Xuat();
                        break;
                    case ThucDon.TimDSPhuongTienCarAndMotorcycle:
                        Console.WriteLine("Tìm danh sách phương tiện là Car và Motorcycle !");
                        ds.TimDSPhuongTien(LoaiPhuongTien.CarAndMotorcycle).Xuat();
                        break;
                    case ThucDon.TimDSPhuongTienCarOrMotorcycle:
                        Console.WriteLine("Tìm danh sách phương tiện là Car hoặc Motorcycle !");
                        ds.TimDSPhuongTien(LoaiPhuongTien.CarOrMotorcycle).Xuat();
                        break;
                    case ThucDon.TimDSDieuKienTen:
                        Console.WriteLine("Tìm danh sách theo tên ");
                        Console.Write("Nhập tên cần tìm : ");
                        string ten5 = Console.ReadLine();
                        ds.TimDSDieuKien(LoaiDieuKien.Ten, ten5, 0,0).Xuat();
                        break;
                    case ThucDon.TimDSDieuKienSoChoNgoi:
                        Console.WriteLine("Tìm danh sách theo số chỗ ngồi ");
                        Console.Write("Nhập số chỗ ngồi cần tìm : ");
                        int soChoNgoi5 = int.Parse(Console.ReadLine());
                        ds.TimDSDieuKien(LoaiDieuKien.SoChoNgoi,null,soChoNgoi5,0).Xuat() ;
                        break;
                    case ThucDon.TimDSDieuKienTocDo:
                        Console.WriteLine("Tìm danh sách theo tốc độ ");
                        Console.Write("Nhập số tốc độ cần tìm : ");
                        int tocDo5 = int.Parse(Console.ReadLine());
                        ds.TimDSDieuKien(LoaiDieuKien.TocDo, null, 0, tocDo5).Xuat();
                        break;
                    case ThucDon.TimDSDieuKienTen_SoChoNgoi:
                        Console.WriteLine("Tìm danh sách theo tên và số chỗ ngồi ");
                        Console.Write("Nhập tên cần tìm : ");
                        string ten6 = Console.ReadLine();
                        Console.Write("Nhập số chỗ ngồi cần tìm :");
                        int soChoNgoi6= int.Parse(Console.ReadLine());
                        ds.TimDSDieuKien(LoaiDieuKien.TenvaSoChoNgoi, ten6, soChoNgoi6, 0).Xuat();
                        break;
                    case ThucDon.TimDSDieuKienTen_TocDo:
                        Console.WriteLine("Tìm danh sách theo tên và tốc độ ");
                        Console.Write("Nhập tên cần tìm : ");
                        string ten7 = Console.ReadLine();
                        Console.Write("Nhập số tốc độ cần tìm : ");
                        int tocDo7 = int.Parse(Console.ReadLine());
                        ds.TimDSDieuKien(LoaiDieuKien.TenvaTocDo, ten7, tocDo7, 0).Xuat();
                        break;
                    case ThucDon.TimDSDieuKienSoChoNgoi_TocDo:
                        Console.WriteLine("Tìm danh sách theo số chỗ ngồi và tốc độ ");
                        Console.Write("Nhập số chỗ ngồi cần tìm : ");
                        int soChoNgoi8 = int.Parse(Console.ReadLine());
                        Console.Write("Nhập số tốc độ cần tìm : ");
                        int tocDo8 = int.Parse(Console.ReadLine());
                        ds.TimDSDieuKien(LoaiDieuKien.SoChoNgoivaTocDo, null, soChoNgoi8, tocDo8).Xuat();
                        break;
                    case ThucDon.TimDSDieuKienTen_SoChoNgoi_TocDo:
                        Console.WriteLine("Tìm danh sách theo tên , số chỗ ngồi, số tốc độ");
                        Console.Write("Nhập tên cần tìm : ");
                        string ten9 = Console.ReadLine();
                        Console.Write("Nhập số chỗ ngồi : ");
                        int soChoNgoi9 = int.Parse(Console.ReadLine());
                        Console.Write("Nhập số tốc độ : ");
                        int tocDo9 = int.Parse(Console.ReadLine());
                        ds.TimDSDieuKien(LoaiDieuKien.TenvaSoChoNgoivaTocDo, ten9, soChoNgoi9, tocDo9).Xuat();
                        break;
                    case ThucDon.TimDSSoSanhTen_Max:
                        Console.WriteLine("Tìm danh sách có tên dài nhất ");
                        ds.TimDSSoSanh(LoaiSoSanh.DaiNhat, LoaiDieuKien.Ten).Xuat();
                        break;
                    case ThucDon.TimDSSoSanhTen_Min:
                        Console.WriteLine("Tìm danh sách có tên ngắn nhất ");
                        ds.TimDSSoSanh(LoaiSoSanh.NganNhat, LoaiDieuKien.Ten).Xuat();
                        break;
                    case ThucDon.TimDSSoSanhSoChoNgoi_Max:
                        Console.WriteLine("Tìm danh sách có số chỗ ngồi lớn nhất ");
                        ds.TimDSSoSanh(LoaiSoSanh.LonNhat,LoaiDieuKien.SoChoNgoi).Xuat();
                        break;
                    case ThucDon.TimDSSoSanhSoChoNgoi_Min:
                        Console.WriteLine("Tìm danh sách có số chỗ ngồi nhỏ nhất ");
                        ds.TimDSSoSanh(LoaiSoSanh.NhoNhat, LoaiDieuKien.SoChoNgoi).Xuat();
                        break;
                    case ThucDon.TimDSSoSanhTocDo_Max:
                        Console.WriteLine("Tìm danh sách có số tốc độ lớn nhất ");
                        ds.TimDSSoSanh(LoaiSoSanh.LonNhat, LoaiDieuKien.TocDo).Xuat();
                        break;
                    case ThucDon.TimDSSoSanhTocDo_Min:
                        Console.WriteLine("Tìm danh sách có số tốc độ nhỏ nhất ");
                        ds.TimDSSoSanh(LoaiSoSanh.NhoNhat, LoaiDieuKien.TocDo).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCar_MinTheoTen:
                        Console.WriteLine("Tìm danh sách phương tiện Car ngắn nhất theo tên ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Car, LoaiDieuKien.Ten, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCar_MaxTheoTen:
                        Console.WriteLine("Tìm danh sách phương tiện Car dài nhất theo tên ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Car, LoaiDieuKien.Ten, TimKiemMaxMin.Max).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCar_MinTheoSoChoNgoi:
                        Console.WriteLine("Tìm danh sách phương tiện Car nhỏ nhất theo số chỗ ngồi ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Car, LoaiDieuKien.SoChoNgoi, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCar_MaxTheoSoChoNgoi:
                        Console.WriteLine("Tìm danh sách phương tiện Car lớn nhất theo số chỗ ngồi ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Car, LoaiDieuKien.SoChoNgoi, TimKiemMaxMin.Max).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCar_MinTheoTocDo:
                        Console.WriteLine("Tìm danh sách phương tiện Car nhỏ nhất theo số tốc độ ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Car, LoaiDieuKien.TocDo, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCar_MaxTheoTocDo:
                        Console.WriteLine("Tìm danh sách phương tiện Car lớn nhất theo số tốc độ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Car, LoaiDieuKien.TocDo, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienMotorcycle_MinTheoTen:
                        Console.WriteLine("Tìm danh sách phương tiện Motorcycle ngắn nhất theo tên");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Motorcycle, LoaiDieuKien.Ten, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienMotorcycle_MaxTheoTen:
                        Console.WriteLine("Tìm danh sách phương tiện Motorcycle dài nhất theo tên ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Motorcycle, LoaiDieuKien.Ten, TimKiemMaxMin.Max).Xuat();
                        break;
                    case ThucDon.TimPhuongTienMotorcycle_MinTheoTocDo:
                        Console.WriteLine("Tìm danh sách phương tiện Motorcycle nhỏ nhất theo tốc độ ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Motorcycle, LoaiDieuKien.TocDo, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienMotorcycle_MaxTheoTocDo:
                        Console.WriteLine("Tìm danh dách phương tiện Motorcycle lớn nhất theo tốc độ ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.Motorcycle, LoaiDieuKien.TocDo, TimKiemMaxMin.Max).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCarAndMotorcycle_MinTheoTen:
                        Console.WriteLine("Tìm danh sách phương tiện Car và Motorcycle ngắn nhất theo tên ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.CarAndMotorcycle, LoaiDieuKien.Ten, TimKiemMaxMin.Min).Xuat();
                        break;
                    case ThucDon.TimPhuongTienCarAndMotorcycle_MaxTheoTen:
                        Console.WriteLine("Tìm danh sách phương tiện Car và Motorcycle dài nhất theo tên ");
                        ds.TimPhuongTienMin_MaxTheoDieuKien(LoaiPhuongTien.CarAndMotorcycle, LoaiDieuKien.Ten, TimKiemMaxMin.Max)
                        break;
                    case ThucDon.TimPhuongTienCarAndMotorcycle_MinTheoTocDo:
                        break;
                    case ThucDon.TimPhuongTienCarAndMotorcycle_MaxTheoTocDo:
                        break;
                    case ThucDon.TimPhuongTienCarOrMotorcycle_MinTheoTen:
                        break;
                    case ThucDon.TimPhuongTienCarOrMotorcycle_MaxTheoTen:
                        break;
                    case ThucDon.TimPhuongTienCarOrMotorcycle_MinTheoTocDo:
                        break;
                    case ThucDon.TimPhuongTienCarOrMotorcycle_MaxTheoTocDo:
                        break;
                    default:
                    case ThucDon.Thoat:
                        return;
                }
                Console.WriteLine("Nhap 1 phim de tiep tuc ");
                Console.ReadKey();
            }



        }
    }

    public enum ThucDon
    {
        NhapTuFile = 1,
        Xuat,
        DemSoLuongPhuongTienCar,
        DemSoLuongPhuongTienMotorcycle,
        DemSoLuongPhuongTienCarAndMotorcycle,
        DemSoLuongPhuongTienCarOrMotorcycle,
        DemSoLuongDemSoLuongTheoTen,
        DemSoLuongTheoChoNgoi,
        DemSoLuongTheoTocDo,
        DemSoLuongTheoTenVaSoChoNgoi,
        DemSoLuongTheoTenVaTocDo,
        DemSoLuongTheoSoChoNgoiVaTocDo,
        DemSoLuongTheoTenVaSoChoNgoivaTocDo,
        DemSoLuongTenDaiNhat,
        DemSoLuongTenNganNhat,
        DemSoLuongChoNgoiLonNhat,
        DemSoLuongChoNgoiNhoNhat,
        DemSoLuongTocDoLonNhat,
        DemSoLuongTocDoNhoNhat,
        TimDSPhuongTienCar,
        TimDSPhuongTienMotorcycle,
        TimDSPhuongTienCarAndMotorcycle,
        TimDSPhuongTienCarOrMotorcycle,
        TimDSDieuKienTen,
        TimDSDieuKienSoChoNgoi,
        TimDSDieuKienTocDo,
        TimDSDieuKienTen_SoChoNgoi,
        TimDSDieuKienTen_TocDo,
        TimDSDieuKienSoChoNgoi_TocDo,
        TimDSDieuKienTen_SoChoNgoi_TocDo,
        TimDSSoSanhTen_Max,
        TimDSSoSanhTen_Min,
        TimDSSoSanhSoChoNgoi_Max,
        TimDSSoSanhSoChoNgoi_Min,
        TimDSSoSanhTocDo_Max,
        TimDSSoSanhTocDo_Min,
        TimPhuongTienCar_MinTheoTen,
        TimPhuongTienCar_MaxTheoTen,
        TimPhuongTienCar_MinTheoSoChoNgoi,
        TimPhuongTienCar_MaxTheoSoChoNgoi,
        TimPhuongTienCar_MinTheoTocDo,
        TimPhuongTienCar_MaxTheoTocDo,
        TimPhuongTienMotorcycle_MinTheoTen,
        TimPhuongTienMotorcycle_MaxTheoTen,
        TimPhuongTienMotorcycle_MinTheoTocDo,
        TimPhuongTienMotorcycle_MaxTheoTocDo,
        TimPhuongTienCarAndMotorcycle_MinTheoTen,
        TimPhuongTienCarAndMotorcycle_MaxTheoTen,
        TimPhuongTienCarAndMotorcycle_MinTheoTocDo,
        TimPhuongTienCarAndMotorcycle_MaxTheoTocDo,
        TimPhuongTienCarOrMotorcycle_MinTheoTen,
        TimPhuongTienCarOrMotorcycle_MaxTheoTen,
        TimPhuongTienCarOrMotorcycle_MinTheoTocDo,
        TimPhuongTienCarOrMotorcycle_MaxTheoTocDo,
        Thoat = 0
    }
}
