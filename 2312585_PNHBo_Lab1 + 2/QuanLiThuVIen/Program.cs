// See https://aka.ms/new-console-template for more information
using QuanLiThuVIen;

// Tạo 5 đối tượng ChiNhanh
ChiNhanh chiNhanh1 = new ChiNhanh("CN001", "Chi nhanh 1", "Dia chi 1");
ChiNhanh chiNhanh2 = new ChiNhanh("CN002", "Chi nhanh 2", "Dia chi 2");
ChiNhanh chiNhanh3 = new ChiNhanh("CN003", "Chi nhanh 3", "Dia chi 3");
ChiNhanh chiNhanh4 = new ChiNhanh("CN004", "Chi nhanh 4", "Dia chi 4");
ChiNhanh chiNhanh5 = new ChiNhanh("CN005", "Chi nhanh 5", "Dia chi 5");

// Xuất thông tin của 5 chi nhánh
Console.WriteLine("Thong tin cua 5 chi nhanh:");
chiNhanh1.Xuat();
chiNhanh2.Xuat();
chiNhanh3.Xuat();
chiNhanh4.Xuat();
chiNhanh5.Xuat();

// Tạo 5 đối tượng NhaSX
NhaSX nhaSX1 = new NhaSX("Nha san xuat 1", "Dia chi NSX 1", "0123456789");
NhaSX nhaSX2 = new NhaSX("Nha san xuat 2", "Dia chi NSX 2", "0987654321");
NhaSX nhaSX3 = new NhaSX("Nha san xuat 3", "Dia chi NSX 3", "0123987654");
NhaSX nhaSX4 = new NhaSX("Nha san xuat 4", "Dia chi NSX 4", "0123654987");
NhaSX nhaSX5 = new NhaSX("Nha san xuat 5", "Dia chi NSX 5", "0123459876");

// Xuất thông tin của 5 nhà sản xuất
Console.WriteLine("\nThong tin cua 5 nha san xuat:");
nhaSX1.Xuat();
nhaSX2.Xuat();
nhaSX3.Xuat();
nhaSX4.Xuat();
nhaSX5.Xuat();

// Tạo 5 đối tượng Sach
Sach sach1 = new Sach("S001", "Sach 1", nhaSX1, "Tac gia 1");
Sach sach2 = new Sach("S002", "Sach 2", nhaSX2, "Tac gia 2");
Sach sach3 = new Sach("S003", "Sach 3", nhaSX3, "Tac gia 3");
Sach sach4 = new Sach("S004", "Sach 4", nhaSX4, "Tac gia 4");
Sach sach5 = new Sach("S005", "Sach 5", nhaSX5, "Tac gia 5");

// Xuất thông tin của 5 sách
Console.WriteLine("\nThong tin cua 5 sach:");
sach1.Xuat();
sach2.Xuat();
sach3.Xuat();
sach4.Xuat();
sach5.Xuat();

// Tạo 5 đối tượng LanMuon
LanMuon lanMuon1 = new LanMuon(DateTime.Now, DateTime.Now.AddDays(7));
LanMuon lanMuon2 = new LanMuon(DateTime.Now.AddDays(1), DateTime.Now.AddDays(8));
LanMuon lanMuon3 = new LanMuon(DateTime.Now.AddDays(2), DateTime.Now.AddDays(9));
LanMuon lanMuon4 = new LanMuon(DateTime.Now.AddDays(3), DateTime.Now.AddDays(10));
LanMuon lanMuon5 = new LanMuon(DateTime.Now.AddDays(4), DateTime.Now.AddDays(11));

// Xuất thông tin của 5 lần mượn
Console.WriteLine("\nThong tin cua 5 lan muon:");
lanMuon1.Xuat();
lanMuon2.Xuat();
lanMuon3.Xuat();
lanMuon4.Xuat();
lanMuon5.Xuat();

// Tạo 5 đối tượng NguoiMuon
NguoiMuon nguoiMuon1 = new NguoiMuon("123456", "Nguoi muon 1", "Dia chi 1", "0123456789");
NguoiMuon nguoiMuon2 = new NguoiMuon("234567", "Nguoi muon 2", "Dia chi 2", "0987654321");
NguoiMuon nguoiMuon3 = new NguoiMuon("345678", "Nguoi muon 3", "Dia chi 3", "0123987654");
NguoiMuon nguoiMuon4 = new NguoiMuon("456789", "Nguoi muon 4", "Dia chi 4", "0123654987");
NguoiMuon nguoiMuon5 = new NguoiMuon("567890", "Nguoi muon 5", "Dia chi 5", "0123459876");

// Xuất thông tin của 5 người mượn
Console.WriteLine("\nThong tin cua 5 nguoi muon:");
nguoiMuon1.Xuat();
nguoiMuon2.Xuat();
nguoiMuon3.Xuat();
nguoiMuon4.Xuat();
nguoiMuon5.Xuat();

// Tạo 5 đối tượng BanSaoSach
BanSaoSach banSaoSach1 = new BanSaoSach(sach1, 5);
BanSaoSach banSaoSach2 = new BanSaoSach(sach2, 3);
BanSaoSach banSaoSach3 = new BanSaoSach(sach3, 7);
BanSaoSach banSaoSach4 = new BanSaoSach(sach4, 2);
BanSaoSach banSaoSach5 = new BanSaoSach(sach5, 6);

// Xuất thông tin của 5 bản sao sách
Console.WriteLine("Thong tin cua 5 ban sao sach:");
banSaoSach1.Xuat();
banSaoSach2.Xuat();
banSaoSach3.Xuat();
banSaoSach4.Xuat();
banSaoSach5.Xuat();