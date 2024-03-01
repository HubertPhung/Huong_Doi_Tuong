// See https://aka.ms/new-console-template for more information
using QuanLiDeTaiKH;

Console.WriteLine("Hello, World!");
List<GiangVien> giangViens = new List<GiangVien>();
List<BoMon> boMons = new List<BoMon>();
List<Khoa> khoas = new List<Khoa>();
List<ChuDe> chuDes = new List<ChuDe>();
List<DeTai> deTais = new List<DeTai>();
List<CongViec> congViecs = new List<CongViec>();

// Tạo 5 đối tượng giảng viên
for (int i = 0; i < 5; i++)
{
    DiaChi diaChiGV = new DiaChi($"So {i + 1}", $"Duong {i + 1}", $"Quan {i + 1}", $"Thanh pho {i + 1}");
    List<string> dienThoaiGV = new List<string> { $"01234567{i}", $"09876543{i}" };
    GiangVien giangVien = new GiangVien($"Giang Vien {i + 1}", diaChiGV, dienThoaiGV, DateTime.Now.AddYears(-30).AddDays(i * 10), 10000000 + i * 500000, i % 2 == 0 ? "Nam" : "Nu", new BoMon());
    giangViens.Add(giangVien);
}

// Tạo 5 đối tượng bộ môn
for (int i = 0; i < 5; i++)
{
    DiaChi diaChiBM = new DiaChi($"So {i + 1}", $"Duong {i + 1}", $"Quan {i + 1}", $"Thanh pho {i + 1}");
    GiangVien truongBoMon = giangViens[i];
    BoMon boMon = new BoMon($"Bo Mon {i + 1}", $"Phong {i + 1}", $"0123456789{i}", truongBoMon, DateTime.Now.AddYears(-10).AddDays(i * 20));
    boMon.DanhSachGiangVien.Add(giangViens[i]);
    boMons.Add(boMon);
}

// Tạo 5 đối tượng khoa
for (int i = 0; i < 5; i++)
{
    GiangVien truongKhoa = giangViens[i];
    Khoa khoa = new Khoa($"Khoa {i + 1}", 2000 + i, $"Phong {i + 1}", $"0123456789{i}", truongKhoa, DateTime.Now.AddYears(-5).AddDays(i * 30));
    khoa.DanhSachBoMon.Add(boMons[i]);
    khoas.Add(khoa);
}

// Tạo 5 đối tượng chủ đề
for (int i = 0; i < 5; i++)
{
    ChuDe chuDe = new ChuDe($"Chu De {i + 1}");
    chuDes.Add(chuDe);
}

// Tạo 5 đối tượng đề tài
for (int i = 0; i < 5; i++)
{
    DeTai deTai = new DeTai($"De Tai {i + 1}", $"Cap Quan Ly {i + 1}", 1000000 + i * 200000, DateTime.Now.AddYears(-1).AddDays(i * 5), DateTime.Now.AddYears(-1).AddDays(i * 10), chuDes[i]);
    deTai.DanhSachCongViec.Add(new CongViec($"Cong Viec 1", DateTime.Now.AddYears(-1).AddDays(i * 5), DateTime.Now.AddYears(-1).AddDays(i * 7)));
    deTai.DanhSachCongViec.Add(new CongViec($"Cong Viec 2", DateTime.Now.AddYears(-1).AddDays(i * 7), DateTime.Now.AddYears(-1).AddDays(i * 9)));
    deTais.Add(deTai);
}

// Tạo 5 đối tượng công việc
for (int i = 0; i < 5; i++)
{
    CongViec congViec = new CongViec($"Cong Viec {i + 1}", DateTime.Now.AddYears(-1).AddDays(i * 5), DateTime.Now.AddYears(-1).AddDays(i * 7));
    congViecs.Add(congViec);
}

// Xuất thông tin
Console.WriteLine("Thong tin giang vien:");
foreach (var gv in giangViens)
{
    gv.XuatThongTin();
    Console.WriteLine();
}

Console.WriteLine("Thong tin bo mon:");
foreach (var bm in boMons)
{
    bm.XuatThongTin();
    Console.WriteLine();
}

Console.WriteLine("Thong tin khoa:");
foreach (var k in khoas)
{
    k.XuatThongTin();
    Console.WriteLine();
}

Console.WriteLine("Thong tin chu de:");
foreach (var cd in chuDes)
{
    cd.XuatThongTin();
    Console.WriteLine();
}

Console.WriteLine("Thong tin de tai:");
foreach (var dt in deTais)
{
    dt.XuatThongTin();
    Console.WriteLine();
}

Console.WriteLine("Thong tin cong viec:");
foreach (var cv in congViecs)
{
    cv.XuatThongTin();
    Console.WriteLine();
}