
using UngDungQuanLyDanhBa;

DanhBa db = new DanhBa();
db.NhapTuFile("data.csv");
db.Xuat();

List<string> kq = db.TimDSCacThanhPho();
foreach(var item in kq)
{
    Console.WriteLine("Thanh Pho " + item);
}