// See https://aka.ms/new-console-template for more information

using Lab2;



Console.WriteLine("Hello, World!");
/*PhanSo ps1 = new PhanSo();
PhanSo ps2 = new PhanSo();
PhanSo ps3 = new PhanSo();
PhanSo ps4 = new PhanSo();
PhanSo ps5 = new PhanSo();*/

/*PhanSo a = new PhanSo(15,5);
a.Xuat();
PhanSo b = new PhanSo(6, 4);
b.Xuat();
Console.WriteLine("Cong phan so: ");
PhanSo kq1 = a.Cong(a, b);
kq1.Xuat();
Console.WriteLine("Tru phan so: ");
PhanSo kq2 = a.Tru(b);
kq2.Xuat();
Console.WriteLine("Nhan phan so: ");
PhanSo kq3 = a.Nhan(b);
kq3.Xuat();
Console.WriteLine("Chia phan so: ");
PhanSo kq4 = a.Chia(b);
kq4.Xuat();
Console.WriteLine("Toi gian phan so a: ");
PhanSo kq5 = a.ToiGian();
kq5.Xuat();*/

PhanSo a = new PhanSo(15, 5);
a.Xuat();
PhanSo b = new PhanSo(6, 4);
b.Xuat();
Console.WriteLine("Cong phan so: ");
PhanSo kq1 = a + b;
kq1.Xuat();
Console.WriteLine("Tru phan so: ");
PhanSo kq2 = a - b;
kq2.Xuat();
Console.WriteLine("Nhan phan so: ");
PhanSo kq3 = a * b;
kq3.Xuat();
Console.WriteLine("Chia phan so: ");
PhanSo kq4 = a / b;
kq4.Xuat();
Console.WriteLine($"Chia lay du: ");
PhanSo kq5 = a % b;
kq5.Xuat();


/*PhanSo ps1 = new PhanSo(7, 8);
ps1.Xuat();
PhanSo ps2 = new PhanSo(2, 4);
ps2.Xuat();
PhanSo ps3 = new PhanSo(5,1);
ps3.Xuat();
PhanSo ps4 = new PhanSo(3,3);
ps4.Xuat();
PhanSo ps5 = new PhanSo(9,5);
ps5.Xuat();*/