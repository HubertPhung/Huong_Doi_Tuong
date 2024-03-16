
using QuanLySinhVien;
using System.Text;


Console.OutputEncoding = Encoding.UTF8;

//SinhVien sv0 = new SinhVien();
//SinhVien sv1 = new SinhVien("2312585", "Phùng Nguyễn Hoài Bo", 8.5f, true, "CTK47A");
//SinhVien sv2 = new SinhVien("2312639", "Địa Chủ Huỳnh", 5.5f, true, "CTK47A");
//SinhVien sv3 = new SinhVien("2312802", "Khánh Vương Vương", 8.6f, true, "CTK47A");
//SinhVien sv4 = new SinhVien("2312590", "Nguyễn Ngọc Trường Dân", 8f, true, "CTK47A");
//SinhVien sv5 = new SinhVien("2312756", "Nguyễn Hưng Thịnh", 2.5f, true, "CTK47A");

//Console.WriteLine(sv1);
//Console.WriteLine(sv2);
//Console.WriteLine(sv3);
//Console.WriteLine(sv4);
//Console.WriteLine(sv5);
SinhVien sv = new SinhVien();
DanhSachSinhVien ds = new DanhSachSinhVien();
DanhSachSinhVien dsphu = new DanhSachSinhVien();
ds.NhapTuFile();
dsphu.NhapTuFile();
//Console.Write(ds);
//Console.ReadKey();
Menu menu = new Menu();
menu.ChayChuongTrinh(ds, dsphu, sv);
