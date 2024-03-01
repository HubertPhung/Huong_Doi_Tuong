// See https://aka.ms/new-console-template for more information
using QuanLiSieuThi;

Console.WriteLine("Hello, World!");




// Tạo 5 đối tượng NhaCungCap
Console.WriteLine("===== Thong tin NhaCungCap =====");
MatHang mhcc = new MatHang("MH001", "Mat hang 1");
MatHang mhcc1 = new MatHang("MH002", "Mat hang 2");
MatHang mhcc2 = new MatHang("MH003", "Mat hang 3");

NhaCungCap ncc1 = new NhaCungCap("PB001", "Cong ty 1", "MST 001", "Dia chi 1", new List<string> { "SDT 1", "SDT 2" }, "Email 1", new List<MatHang> { mhcc});
NhaCungCap ncc2 = new NhaCungCap("PB002", "Cong ty 2", "MST 002", "Dia chi 2", new List<string> { "SDT 3", "SDT 4" }, "Email 2", new List<MatHang> { mhcc1, mhcc});
NhaCungCap ncc3 = new NhaCungCap("PB003", "Cong ty 3", "MST 003", "Dia chi 3", new List<string> { "SDT 5", "SDT 6" }, "Email 3", new List<MatHang> { mhcc, mhcc2});
NhaCungCap ncc4 = new NhaCungCap("PB004", "Cong ty 4", "MST 004", "Dia chi 4", new List<string> { "SDT 7", "SDT 8" }, "Email 4", new List<MatHang> { mhcc1, mhcc2});
NhaCungCap ncc5 = new NhaCungCap("PB005", "Cong ty 5", "MST 005", "Dia chi 5", new List<string> { "SDT 9", "SDT 10" }, "Email 5", new List<MatHang> { mhcc2});

ncc1.Xuat();
ncc2.Xuat();
ncc3.Xuat();
ncc4.Xuat();
ncc5.Xuat();

// Tạo 5 đối tượng MatHang
Console.WriteLine("===== Thong tin MatHang =====");
MatHang mh1 = new MatHang("MH001", "Mat hang 1", 1, 10000, new List<NhaCungCap> { ncc1, ncc5 });
MatHang mh2 = new MatHang("MH002", "Mat hang 2", 2, 20000, new List<NhaCungCap> { ncc2 });
MatHang mh3 = new MatHang("MH003", "Mat hang 3", 3, 30000, new List<NhaCungCap> { ncc3 });
MatHang mh4 = new MatHang("MH004", "Mat hang 4", 4, 40000, new List<NhaCungCap> { ncc4 });
MatHang mh5 = new MatHang("MH005", "Mat hang 5", 5, 50000, new List<NhaCungCap> { ncc2, ncc3 });
mh1.Xuat();
mh2.Xuat();
mh3.Xuat();
mh4.Xuat();
mh5.Xuat();

// Tạo 5 đối tượng LoaiHang
Console.WriteLine("===== Thong tin LoaiHang =====");
LoaiHang lh1 = new LoaiHang("LH001", "Loai hang 1", new List<MatHang> { mh1, mh2 });
LoaiHang lh2 = new LoaiHang("LH002", "Loai hang 2", new List<MatHang> { mh3, mh4 });
LoaiHang lh3 = new LoaiHang("LH003", "Loai hang 3", new List<MatHang> { mh5, mh1 });
LoaiHang lh4 = new LoaiHang("LH004", "Loai hang 4", new List<MatHang> { mh2, mh3 });
LoaiHang lh5 = new LoaiHang("LH005", "Loai hang 5", new List<MatHang> { mh4, mh5 });
lh1.Xuat();
lh2.Xuat();
lh3.Xuat();
lh4.Xuat();
lh5.Xuat();


// Tạo và xuất thông tin cho 5 đối tượng KhuVuc
Console.WriteLine("===== Thong tin KhuVuc =====");
KhuVuc kv1 = new KhuVuc("KV001", "Khu vuc 1", new LoaiHang());
KhuVuc kv2 = new KhuVuc("KV002", "Khu vuc 2", new LoaiHang());
KhuVuc kv3 = new KhuVuc("KV003", "Khu vuc 3", new LoaiHang());
KhuVuc kv4 = new KhuVuc("KV004", "Khu vuc 4", new LoaiHang());
KhuVuc kv5 = new KhuVuc("KV005", "Khu vuc 5", new LoaiHang());
kv1.Xuat();
kv2.Xuat();
kv3.Xuat();
kv4.Xuat();
kv5.Xuat();



// Tạo và xuất thông tin cho 5 đối tượng NhanVien
Console.WriteLine("===== Thong tin NhanVien =====");
NhanVien nv1 = new NhanVien(kv1, "NV001", "Nhan vien 1", new DateTime(2022, 3, 15), "Dia chi 1", "SDT 1", new DateTime(2022, 3, 15), "CMND 1");
NhanVien nv2 = new NhanVien(kv2, "NV002", "Nhan vien 2", new DateTime(2022, 3, 16), "Dia chi 2", "SDT 2", new DateTime(2022, 3, 16), "CMND 2");
NhanVien nv3 = new NhanVien(kv3, "NV003", "Nhan vien 3", new DateTime(2022, 3, 17), "Dia chi 3", "SDT 3", new DateTime(2022, 3, 17), "CMND 3");
NhanVien nv4 = new NhanVien(kv4, "NV004", "Nhan vien 4", new DateTime(2022, 3, 18), "Dia chi 4", "SDT 4", new DateTime(2022, 3, 18), "CMND 4");
NhanVien nv5 = new NhanVien(kv5, "NV005", "Nhan vien 5", new DateTime(2022, 3, 19), "Dia chi 5", "SDT 5", new DateTime(2022, 3, 19), "CMND 5");
nv1.Xuat();
nv2.Xuat();
nv3.Xuat();
nv4.Xuat();
nv5.Xuat();

// Tạo và xuất thông tin cho 5 đối tượng HoaDon

List<MatHang> dsMatHang1 = new List<MatHang>() { mh1, mh2 };
List<MatHang> dsMatHang2 = new List<MatHang>() { mh3, mh4 };
List<MatHang> dsMatHang3 = new List<MatHang>() { mh5 };
HoaDon hoaDon1 = new HoaDon("HD001", new DateTime(2022, 3, 15), nv1, "Khach hang 1", "Dia chi 1", dsMatHang1, 10000, 100000, 110000);
HoaDon hoaDon2 = new HoaDon("HD002", new DateTime(2022, 3, 16), nv2, "Khach hang 2", "Dia chi 2", dsMatHang2, 20000, 200000, 220000);
HoaDon hoaDon3 = new HoaDon("HD003", new DateTime(2022, 3, 17), nv3, "Khach hang 3", "Dia chi 3", dsMatHang3, 30000, 300000, 330000);
HoaDon hoaDon4 = new HoaDon("HD004", new DateTime(2022, 3, 18), nv4, "Khach hang 4", "Dia chi 4", dsMatHang1, 40000, 400000, 440000);
HoaDon hoaDon5 = new HoaDon("HD005", new DateTime(2022, 3, 19), nv5, "Khach hang 5", "Dia chi 5", dsMatHang2, 50000, 500000, 550000);

hoaDon1.Xuat();
hoaDon2.Xuat();
hoaDon3.Xuat();
hoaDon4.Xuat();
hoaDon5.Xuat();