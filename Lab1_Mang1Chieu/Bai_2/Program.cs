List<int> a = new List<int>();
// Nhập Xuất Mảng
NhapNgauNhien(a);
Xuat(a);
//2.1
Console.WriteLine($"\nTong cua cac phan tu trong List la : {TinhTong(a)}.");
//2.2
TinhTB(a);
//2.3
TimMAX(a);
//2.4
TimMIN(a);
//2.5
Console.Write("Nhap So Can Tim So Lan Xuat Hien : ");
int x = int.Parse(Console.ReadLine());
TimSoLanXuatHien(a, x);
//2.6
TinhTongSoAm(a);
//2.7
TinhTongSoDuong(a);
//2.8
DemSoChan(a);
//2.9
DemSoLe(a);
//2.10
DemPhanTuX(a, x);


static void NhapNgauNhien(List<int> a)
{
    int length = 0;
    Console.Write("\nNhap vao chieu dai mang : ");
    length = int.Parse(Console.ReadLine());
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
        a.Add(r.Next(-100, 101));
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
    Console.WriteLine($"Tinh trung binh cua List la : {dem}.");
}

//2.3	Tìm giá trị lớn nhất trong danh sách.
static void TimMAX(List<int> a)
{
    Console.WriteLine($"Gia Tri Lon Nhat La : {a.Max()}.");
}

//2.4	Tìm giá trị nhỏ nhất trong danh sách.
static void TimMIN(List<int> a)
{
    Console.WriteLine($"Gia Tri Nho Nhat La : {a.Min()}.");
}

//2.5	Tìm số lần xuất hiện của một giá trị trong danh sách.
static void TimSoLanXuatHien(List<int> a, int x)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == x)
            dem++;
    }
    Console.WriteLine($"So Lan Xuat Hien Cua {x} La : {dem}.");
}

//2.6	Tính tổng các số âm trong danh sách.
static void TinhTongSoAm(List<int> a)
{
    int temp = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] < 0)
        temp += a[i];
    }
    Console.WriteLine($"Tinh Tong Cac So Am Trong Danh Sach La : {temp}.");
}

//2.7	Tính tổng các số dương trong danh sách.
static void TinhTongSoDuong(List<int> a)
{
    int temp = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > 0)
            temp += a[i];
    }
    Console.WriteLine($"Tinh Tong Cac So Duong Trong Danh Sach La : {temp}.");
}

//2.8	Đếm số chẵn
static void DemSoChan(List<int> a)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] % 2 == 0)
            dem++;
    }
    Console.WriteLine($"So Chan Trong Danh Sach Co {dem} So.");
}

//2.9	Đếm số lẽ
static void DemSoLe(List<int> a)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (!(a[i] % 2 == 0))
            dem++;
    }
    Console.WriteLine($"So Le Trong Danh Sach Co {dem} So.");
}

//2.10	Đếm phần tử x trong danh sách
static void DemPhanTuX(List<int> a, int x)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == x)
            dem++;
    }
    Console.WriteLine($"Phan Tu {x} Trong Danh Sach Co {dem} So.");
}
