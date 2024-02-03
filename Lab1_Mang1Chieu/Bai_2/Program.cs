List<int> a = new List<int>();
// Nhập Xuất Mảng
NhapMang(a);
Xuat(a);
//2.1
Console.WriteLine($"\nTong cua cac phan tu trong List la : {TinhTong(a)}");
//2.2
TinhTB(a);
//2.3
TimMAX(a);
//2.4
TimMIN(a);
//2.5

TimSoLanXuatHien(a);



static void NhapMang(List<int> a)
{
    Console.Write("Nhap so phan tu cua mang: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.Write("Nhap phan tu thu {0}: ", i);
        a.Add(int.Parse(Console.ReadLine()));
    }
}

static void Xuat(List<int> a)
{
    foreach (int i in a)
    {
        Console.Write($"{i}   ");

    }
}

//2.1	Tính tổng các phần tử trong danh sách.
static int TinhTong(List<int> a)
{
    int temp = 0;
    for(int i = 0;i < a.Count; i++)
    {
        temp += a[i];
    }
    return temp;
}

//2.2	Tính trung bình các phần tử trong danh sách.
static void TinhTB(List<int> a)
{
    double dem = TinhTong(a) / a.Count;
    Console.WriteLine($"Tinh trung binh cua List la : {dem}");
}

//2.3	Tìm giá trị lớn nhất trong danh sách.
static void TimMAX(List<int> a)
{
    Console.WriteLine($"Gia Tri Lon Nhat La : {a.Max()}");
}

//2.4	Tìm giá trị nhỏ nhất trong danh sách.
static void TimMIN(List<int> a)
{
    Console.WriteLine($"Gia Tri Nho Nhat La : {a.Min()}");
}

//2.5	Tìm số lần xuất hiện của một giá trị trong danh sách.
static void TimSoLanXuatHien(List<int> a)
{
    int dem = 0;
    Console.Write("Nhap So Can Tim So Lan Xuat Hien : ");
    int x = Console.Read();
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == x)
            dem++;
    }
    Console.WriteLine($"So Lan Xuat Hien Cua {x} La : {dem}");

}