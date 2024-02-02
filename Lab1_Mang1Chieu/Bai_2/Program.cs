List<int> a = new List<int>();
// Nhập Xuất Mảng
NhapMang(a);
Xuat(a);
//2.1
Console.WriteLine($"\nTong cua cac phan tu trong List la : {TinhTong(a)}");
//2.2
TinhTB(a);


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
