List<int> a = new List<int>();
// Nhập Xuất Mảng
NhapNgauNhien(a);
Xuat(a);
//4.1
int temp = 0;
Console.WriteLine("\nSap xep danh sach theo thu tu TANG DAN la :\n");
List<int> ascending = OrderByAscending(a);
foreach (int item in ascending)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}
//4.2
Console.WriteLine("\nSap xep danh sach theo thu tu GIAM DAN la :");
List<int> descending = OrderByDescending(a);
foreach (int item in descending)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}

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


//4.1 Sắp xếp danh sách theo thứ tự tăng dần.
static List<int> OrderByAscending(List<int> a)
{
    List<int> ascending = a.OrderBy(x => x).ToList();
    return ascending;
}
//4.2	Sắp xếp danh sách theo thứ tự giảm dần.
static List<int> OrderByDescending(List<int> a)
{
    List<int> descending = a.OrderByDescending(x => x).ToList();
    return descending;
}