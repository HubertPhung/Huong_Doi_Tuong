
List<int> a = new List<int>();
NhapNgauNhien(a);
Xuat(a);
//3.1
Console.WriteLine($"\nNhap So Can Kiem Tra: ");
int x =int.Parse(Console.ReadLine());
KtraX(a, x);
//3.2
Console.WriteLine("Nhap So Can Tim So Lan Xuat Hien : ");
int s = int.Parse(Console.ReadLine());
TimSoLanXuatHien(a, s);
//3.3
Console.WriteLine("Tim Tat Ca Cac Vi Tri Trong Phan Tu X : ");
int f = int.Parse(Console.ReadLine());
Console.Write("Vi Tri :");
TimTatCaVtriCuaPhanTuX(a, f);
//3.4
Console.WriteLine("\n");
TimVTDauTienList(a);
//3.5
TimVTCuoiCung(a);
//3.6
Console.WriteLine($"\nCac So Duong Trong Danh Sach La : ");
TimVTSoDuong(a);


static void NhapNgauNhien(List<int> a)
{
    int length = 0;
    Console.Write("\nNhap vao chieu dai mang : ");
    length = int.Parse(Console.ReadLine());
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
        a.Add(r.Next(-100 ,101));
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
    foreach (int i in a)
    {
        if (i == x)
        {
            Console.WriteLine($"Phan Tu {x} Co Trong Danh Sach");
            return;
        }
    }
    Console.WriteLine("Khong co  ");
    return;
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
static void TimTatCaVtriCuaPhanTuX(List<int> a, int f)
{
    
    for(int i = 0;i < a.Count; i++)
    {
        if (a[i] == f)

        {
            Console.Write($"\t{i}");
        }
    }
}

//3.4	Tìm vị trí đầu tiên của phần tử trong danh sách
static void TimVTDauTienList(List<int> a)
{
    for(int i = 0; i < a.Count; i++)
    {
        Console.WriteLine($"Vi Tri DAU TIEN Cua Phan Tu Trong LIST La : {i}");
        break;
    }
}
//3.5	Tìm vị trí cuối cùng của phần tử x trong danh sách
static void TimVTCuoiCung(List<int> a)
{
    for(int i = a.Count - 1; i >= 0 ; i--)
    {
        Console.WriteLine($"Vi Tri CUOI CUNG Cua Phan Tu Trong LIST La : {i}");
        break;
    }
}
//3.6	Tìm vị trí của các số dương trong danh sách
static void TimVTSoDuong(List<int> a)
{
    int vitri;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > 0)
        {
            Console.WriteLine($"   {i}");
        }
    }
    
}
//3.7	Tìm vị trí của các số âm trong danh sách
//3.8	Tìm vị trí của số lớn nhất trong danh sách
//3.9	Tìm vị trí của số nhỏ nhất trong danh sách
//3.10	Tìm tất cả số chẵn trong danh sách
//3.11	Tìm tất cả số lẽ trong danh sách
//3.12	Tìm số nguyên xuất hiện nhiều nhất trong danh sách
//3.13	Tìm số nguyên xuất hiện ít nhất trong danh sách
//3.14	Tìm tất cả các phần tử trong danh sách (không trùng nhau). Ví dụ danh sách 1 2 3 1 2 thì trả về 1 2 3 
//3.15	Tìm số lần xuất hiện của các phần tử trong danh sách
//3.16	Tìm vị trí đầu tiên của danh sách x trong danh sách. Ví dụ: với danh sách 1 2 3 4 5 2 3 và mảng x là 2 3 thì vị trí trả về là 2
//3.17	Tìm vị trí cuối cùng của danh sách x trong danh sách. 
//3.18	Tìm hợp của 2 danh sách
//3.19	Tìm giao của 2 danh sách
//3.20	Tìm hiệu của 2 danh sách
//3.21	Tìm phần tử xuất hiện ít nhất trong danh sách
//3.22	Tìm phần tử xuất hiện nhiều nhất trong danh sách
