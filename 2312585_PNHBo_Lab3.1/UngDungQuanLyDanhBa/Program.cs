
using UngDungQuanLyDanhBa;

DanhBa db = new DanhBa();
db.NhapTuFile("data.csv");
db.Xuat();

Console.WriteLine();
List<string> kq = db.TimDSCacThanhPho();
foreach(var item in kq)
{
    Console.WriteLine("Thanh Pho " + item);
}

Console.WriteLine();
foreach (var item in kq)
{
    Console.WriteLine(item + " so thue bao " + db.DemSoThueBaoTheoTP(item));
}
