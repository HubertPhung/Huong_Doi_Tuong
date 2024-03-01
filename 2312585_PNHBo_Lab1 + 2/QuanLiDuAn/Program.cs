// See https://aka.ms/new-console-template for more information
using QuanLiDuAn;

Console.WriteLine("Hello, World!");

// Khởi tạo 5 đối tượng ThanNhan
ThanNhan thanNhan1 = new ThanNhan("Nguyen Van A", "Nam", new DateTime(1980, 5, 10), "Cha");
ThanNhan thanNhan2 = new ThanNhan("Tran Thi B", "Nu", new DateTime(1982, 8, 15), "Me");
ThanNhan thanNhan3 = new ThanNhan("Nguyen Thi C", "Nu", new DateTime(2005, 3, 20), "Con gai");
ThanNhan thanNhan4 = new ThanNhan("Tran Van D", "Nam", new DateTime(2010, 7, 25), "Con trai");
ThanNhan thanNhan5 = new ThanNhan("Le Van E", "Nam", new DateTime(1975, 12, 30), "Anh trai");

// Khởi tạo 5 đối tượng Phong
Phong phong1 = new Phong("P001", "Phong Ke Toan", new NhanVien("NV006","Nguyen A"), new DateTime(2010, 3, 15), new List<string> { "Tang 1, Toa nha A", "Tang 2, Toa nha B" }, new List<DuAn>());
Phong phong2 = new Phong("P002", "Phong Ky Thuat", new NhanVien("NV007", "Pham B"), new DateTime(2011, 4, 20), new List<string> { "Tang 3, Toa nha A" }, new List<DuAn>());
Phong phong3 = new Phong("P003", "Phong Marketing", new NhanVien("NV008", "Vo C"), new DateTime(2012, 5, 25), new List<string> { "Tang 4, Toa nha B" }, new List<DuAn>());
Phong phong4 = new Phong("P004", "Phong Nhan Su", new NhanVien("NV009", "Phan D"), new DateTime(2013, 6, 30), new List<string> { "Tang 5, Toa nha A" }, new List<DuAn>());
Phong phong5 = new Phong("P005", "Phong IT", new NhanVien("NV0010", "Tran E"), new DateTime(2014, 7, 5), new List<string> { "Tang 6, Toa nha B" }, new List<DuAn>());

// Khởi tạo 6 đối tượng DuAn
DuAn duAn1 = new DuAn("DA001", "Xay dung he thong quan ly", "Dia diem A", phong1, new Dictionary<NhanVien, int>());
DuAn duAn2 = new DuAn("DA002", "Phat trien ung dung di dong", "Dia diem B", phong1, new Dictionary<NhanVien, int>());
DuAn duAn3 = new DuAn("DA003", "Nghien cuu cong nghe moi", "Dia diem C", phong2, new Dictionary<NhanVien, int>());
DuAn duAn4 = new DuAn("DA004", "Chien luoc tiep thi moi", "Dia diem D", phong3, new Dictionary<NhanVien, int>());
DuAn duAn5 = new DuAn("DA005", "Tuyen dung va dao tao nhan su", "Dia diem E", phong4, new Dictionary<NhanVien, int>());

// Khởi tạo 5 đối tượng NhanVien
NhanVien nhanVien1 = new NhanVien("NV001", "Nguyen Van A", "123 Duong ABC, Quan 1, TP.HCM", 5000, "Nam", new DateTime(1985, 10, 15), phong1, new List<DuAn>(), new NhanVien(), new List<ThanNhan> { thanNhan1, thanNhan2 });
NhanVien nhanVien2 = new NhanVien("NV002", "Tran Thi B", "456 Duong XYZ, Quan 2, TP.HCM", 4500, "Nu", new DateTime(1988, 12, 20), phong2, new List<DuAn>(), new NhanVien(), new List<ThanNhan> { thanNhan3 });
NhanVien nhanVien3 = new NhanVien("NV003", "Nguyen Van C", "789 Duong DEF, Quan 3, TP.HCM", 4000, "Nam", new DateTime(1990, 5, 25), phong3, new List<DuAn>(), new NhanVien(), new List<ThanNhan> { thanNhan4 });
NhanVien nhanVien4 = new NhanVien("NV004", "Tran Thi D", "101 Duong UVW, Quan 4, TP.HCM", 5500, "Nu", new DateTime(1987, 7, 30), phong4, new List<DuAn>(), new NhanVien(), new List<ThanNhan> { thanNhan5 });
NhanVien nhanVien5 = new NhanVien("NV005", "Le Van E", "202 Duong LMN, Quan 5, TP.HCM", 6000, "Nam", new DateTime(1983, 9, 10), phong5, new List<DuAn>(), new NhanVien(), new List<ThanNhan> { thanNhan1 });

// Để giữ màn hình console mở sau khi chương trình chạy xong
Console.ReadLine();
// Xuất thông tin của các đối tượng
Console.WriteLine("Thong tin cua cac doi tuong:");
Console.WriteLine();

Console.WriteLine("Thong tin cua 5 doi tuong ThanNhan:");
thanNhan1.Xuat();
Console.WriteLine();
thanNhan2.Xuat();
Console.WriteLine();
thanNhan3.Xuat();
Console.WriteLine();
thanNhan4.Xuat();
Console.WriteLine();
thanNhan5.Xuat();
Console.WriteLine();

Console.WriteLine("Thong tin cua 5 doi tuong Phong:");
phong1.Xuat();
Console.WriteLine();
phong2.Xuat();
Console.WriteLine();
phong3.Xuat();
Console.WriteLine();
phong4.Xuat();
Console.WriteLine();
phong5.Xuat();
Console.WriteLine();

Console.WriteLine("Thong tin cua 6 doi tuong DuAn:");
duAn1.Xuat();
Console.WriteLine();
duAn2.Xuat();
Console.WriteLine();
duAn3.Xuat();
Console.WriteLine();
duAn4.Xuat();
Console.WriteLine();
duAn5.Xuat();
Console.WriteLine();

Console.WriteLine("Thong tin cua 5 doi tuong NhanVien:");
nhanVien1.Xuat();
Console.WriteLine();
nhanVien2.Xuat();
Console.WriteLine();
nhanVien3.Xuat();
Console.WriteLine();
nhanVien4.Xuat();
Console.WriteLine();
nhanVien5.Xuat();