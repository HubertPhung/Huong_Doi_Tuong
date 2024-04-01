
using UngDungQuanLyDanhBa;

DanhBa db = new DanhBa();
//db.NhapTuFile("data.csv");
//db.Xuat();

//Console.WriteLine();
//List<string> kq = db.TimDSCacThanhPho();
//foreach(var item in kq)
//{
//    Console.WriteLine("Thanh Pho " + item);
//}

//Console.WriteLine();
//foreach (var item in kq)
//{
//    Console.WriteLine(item + " so thue bao " + db.DemSoThueBaoTheoTP(item));
//}

//Console.WriteLine();
//List<string> kq1 = db.TimTPCoNhieuThueBaoNhat();
//foreach (var item in kq1)
//{
//    Console.WriteLine(item + " so thue bao lon nhat " + db.DemSoThueBaoTheoTP(item));
//}


while (true)
{
    Console.Clear();
    Console.WriteLine("Chon chuc nang ");
    Console.WriteLine($"Nhap {(int)ThucDon.NhapTuFile} de nhap tu file ");
    Console.WriteLine($"Nhap {(int)ThucDon.Xuat} de xuat danh ba");
    Console.WriteLine($"Nhap {(int)ThucDon.TimDSCacThanhPho} de tim danh sach cac thanh pho");
    Console.WriteLine($"Nhap {(int)ThucDon.DemSoThueBaoTheoTP} de dem so thue bao theo thanh pho");
    Console.WriteLine($"Nhap {(int)ThucDon.TimTPCoNhieuThueBaoNhat} de tim thanh pho co nhieu thue bao nhat ");
    Console.WriteLine($"Nhap {(int)ThucDon.Them} de them thue bao");
    Console.WriteLine($"Nhap {(int)ThucDon.Thoat} de thoat");
    ThucDon chon = (ThucDon)int.Parse(Console.ReadLine());

    switch (chon)
    {
        case ThucDon.NhapTuFile:
            db.NhapTuFile("data.csv");
            break;
        case ThucDon.Xuat:
            db.Xuat();
            break;
        case ThucDon.TimDSCacThanhPho:
            List<string> kq = db.TimDSCacThanhPho();
            foreach (var item in kq)
            {
                Console.WriteLine($"Thanh pho {item}");
            }
            break;
        case ThucDon.DemSoThueBaoTheoTP:
            List<string> kq1 = db.TimDSCacThanhPho();
            foreach (var item in kq1)
            {
                Console.WriteLine(item + " so thue bao " + db.DemSoThueBaoTheoTP(item));
            }
            break;
        case ThucDon.TimTPCoNhieuThueBaoNhat:
            List<string> kq2 = db.TimTPCoNhieuThueBaoNhat();
            foreach (var item in kq2)
            {
                Console.WriteLine(item + " so thue bao lon nhat " + db.DemSoThueBaoTheoTP(item));
            }
            break;
        case ThucDon.Them:
            db.NhapTuFile("data.csv");
            ThueBao thueBaoMoi = new ThueBao("An Giang", GioiTinh.Nam, "Hoai Bo", DateTime.Now, "0988752291", "12348");
            db.Them(thueBaoMoi);   
            db.Xuat();
            break;
        default:
            return;
    }
    Console.WriteLine("Nhap 1 phim de tiep tuc ");
    Console.ReadKey();
}

public enum ThucDon
{
    NhapTuFile = 1,
    Xuat,
    TimDSCacThanhPho,
    DemSoThueBaoTheoTP,
    TimTPCoNhieuThueBaoNhat,
    Them,
    Thoat
}


