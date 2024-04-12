
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
    Console.WriteLine("=====================================Chon chuc nang======================================");
    Console.WriteLine($"Nhap {(int)ThucDon.Nhap} de nhap bang tay ");
    Console.WriteLine($"Nhap {(int)ThucDon.NhapTuFile} de nhap tu file ");
    Console.WriteLine($"Nhap {(int)ThucDon.Xuat} de xuat danh ba");
    Console.WriteLine($"Nhap {(int)ThucDon.TimDSCacThanhPho} de tim danh sach cac thanh pho");
    Console.WriteLine($"Nhap {(int)ThucDon.DemSoThueBaoTheoTP} de dem so thue bao theo thanh pho");
    Console.WriteLine($"Nhap {(int)ThucDon.TimTPCoNhieuThueBaoNhat} de tim thanh pho co nhieu thue bao nhat ");
    //Console.WriteLine($"Nhap {(int)ThucDon.Them} de them thue bao");
    Console.WriteLine($"Nhap {(int)ThucDon.TimAllTPCoSoThueBaoX} de tim tat ca thanh pho co so thue bao x");
    Console.WriteLine($"Nhap {(int)ThucDon.TimTPCoItThueBaoNhat} de tim thanh pho co it thue bao nhat");
    Console.WriteLine($"Nhap {(int)ThucDon.Thoat} de thoat");
    Console.WriteLine("=========================================================================================");
    Console.Write("Nhap so Menu : ");
    ThucDon chon = (ThucDon)int.Parse(Console.ReadLine());

    switch (chon)
    {
        case ThucDon.Nhap:
            Console.Write("Nhap so thue bao can nhap : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao thong tin sinh vien {0}:", i + 1);
                db.Nhap(n);
            }
            break;
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
            //List<string> kq1 = db.TimDSCacThanhPho();
            //foreach (var item in kq1)
            //{
            //    Console.WriteLine(item + " so thue bao " + db.DemSoThueBaoTheoTP(item));
            //}
            db.XuatTBTheoTP();
            break;
        case ThucDon.TimTPCoNhieuThueBaoNhat:
            List<string> kq2 = db.TimTPCoNhieuThueBaoNhat();
            foreach (var item in kq2)
            {
                Console.WriteLine(item + " so thue bao lon nhat " + db.DemSoThueBaoTheoTP(item));
            }
            break;
        //case ThucDon.Them:
        //    db.NhapTuFile("data.csv");
        //    ThueBao thueBaoMoi = new ThueBao("An Giang", GioiTinh.Nam, "Hoai Bo", DateTime.Now, "0988752291", "12348");
        //    db.Them(thueBaoMoi);   
        //    db.Xuat();
        //    break;
        case ThucDon.TimAllTPCoSoThueBaoX:
            db.Xuat();
            Console.Write("Nhap so thue bao can tim : ");
            string x = Console.ReadLine();
            List<string> kq3 = db.TimAllTPCoSoThueBaoX(x);
            foreach (var item in kq3)
            {
                    Console.WriteLine($"Tat ca thanh pho co so " + x + " la " + item);
            }
            if (kq3.Count == 0)
            Console.WriteLine("Khong co so thue bao can tim!");
            break;
        case ThucDon.TimTPCoItThueBaoNhat:
            db.Xuat();
            List<string> kq4 = db.TimTPCoItThueBaoNhat();
            foreach (var item in kq4)
            {
                Console.WriteLine(item + " co thue bao it nhat la '" + db.DemSoThueBaoTheoTP(item) + "' thue bao.");
            }
            break;
        case ThucDon.SapXepTangTheoHoTenDienThoai:

            Console.WriteLine("1. Sap xep tang theo ho ten va so dien thoai.");
            Console.WriteLine("2. Sap xep giam theo ho te va so dien thoai.");
            Console.Write("Chon 1 hoac 2 : ");
            int m = int.Parse(Console.ReadLine());
            if(m == 1)
            {
                db.Xuat();
                db.SapXepTangTheoHoTenDienThoai();
                Console.WriteLine("Da Sap Xep Tang : ");
                db.Xuat();
            }
            else
            {
                db.Xuat();
                db.SapXepGiamTheoHoTenDienThoai();
                Console.WriteLine("Da Sap Xep : ");
                db.Xuat();
            }
            break;
        case ThucDon.HienThiDSTPTheoChieuTangGiamSLTB:
           
            break;

        case ThucDon.HienThiDBTheoCacTruongTrongThueBao:
            ThueBao ds = new ThueBao();
            db.Xuat();
            db.SapXepHoTen();
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
    Nhap = 1,
    NhapTuFile = 2,
    Xuat,
    TimDSCacThanhPho,
    DemSoThueBaoTheoTP,
    TimTPCoNhieuThueBaoNhat,
    //Them,
    TimAllTPCoSoThueBaoX,
    TimTPCoItThueBaoNhat,
    SapXepTangTheoHoTenDienThoai,
    HienThiDSTPTheoChieuTangGiamSLTB,
    HienThiDBTheoCacTruongTrongThueBao,
    Thoat
}


