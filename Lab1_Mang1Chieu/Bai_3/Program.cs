
List<int> a = new List<int>();

//3.1
Console.WriteLine($"Nhap So Can Kiem Tra: ");
int x =int.Parse(Console.ReadLine());
KtraX(a, x);
//3.2
Console.Write("Nhap So Can Tim So Lan Xuat Hien : ");
int s = int.Parse(Console.ReadLine());
TimSoLanXuatHien(a, s);
//3.3


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


//3.1	Kiểm tra phần tử x có chứa trong danh sách hay không
static void KtraX(List<int> a, int x)
{
    for(int i = 0;i < a.Count; i++)
    {
        if (a[i] == x)
        {
            Console.WriteLine($"Phan Tu {x} Co Trong Danh Sach");
        }
        else
        {
            Console.WriteLine($"Khong Co Trong Danh Sach");
        }
    }
}

//3.2	Tìm số lần xuất hiện của một giá trị trong danh sách
static void TimSoLanXuatHien(List<int> a, int s)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == s)
            dem++;
    }
    Console.WriteLine($"So Lan Xuat Hien Cua {s} La : {dem}.");
}

//3.3	Tìm tất cả vị trí của phần tử x trong danh sách
static void TimTatCaVtriCuaPhanTuX(List<int> a, int s)
{
    int index1 = a.IndexOf(s);
    for(int i = 0;i < a.Count; i++)
    {
        if (a[i] == s)
        {
            Console.WriteLine(Index1);
        }
    }
}