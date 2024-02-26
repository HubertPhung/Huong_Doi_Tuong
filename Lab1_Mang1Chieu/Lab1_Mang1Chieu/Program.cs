
List<int> a = new List<int>();
//List<int> a = new List<int> { 1, 2, 3, 4 , 5, 6 ,7 ,8};

//Ham main------------------------------------------------------------------
//1.1	Nhập từ bàn phím
//NhapMang(a);
//1.2 Nhập ngẫu nhiên
NhapNgauNhien(a);
//1.3	Nhập từ File
//Console.WriteLine("Nhap ten file can doc : ");
//string s = Console.ReadLine();
//DocFile(a, s);
//1.4	Xuất ra Console
Xuat(a);
//1.5	Xuất ra File
//XuatFile(a, s);


//2.1
Console.WriteLine($"\n2.1 Tong cua cac phan tu trong List la : {TinhTong(a)}.");
//2.2
Console.WriteLine($"2.2 Tinh trung binh cua List la : {TinhTB(a)}.");
//2.3
Console.WriteLine($"2.3 Gia Tri Lon Nhat La : {TimMAX(a)}.");
//2.4
Console.WriteLine($"2.4 Gia Tri Nho Nhat La : {TimMIN(a)}.");
//2.5
Console.Write("2.5 Nhap So Can Tim So Lan Xuat Hien (x) : ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine($"==> So Lan Xuat Hien Cua {x} La : {TimSoLanXuatHien(a, x)}.");
//2.6
Console.WriteLine($"2.6 Tinh Tong Cac So Am Trong Danh Sach La : {TinhTongSoAm(a)}.");
//2.7
Console.WriteLine($"2.7 Tinh Tong Cac So Duong Trong Danh Sach La : {TinhTongSoDuong(a)}.");
//2.8
Console.WriteLine($"2.8 So Chan Trong Danh Sach Co {DemSoChan(a)} So.");
//2.9
Console.WriteLine($"2.9 So Le Trong Danh Sach Co {DemSoLe(a)} So.");
//2.10
Console.WriteLine($"2.10 Phan Tu {x} Trong Danh Sach Co {DemPhanTuX(a, x)} So.");
//3.1
Xuat(a);
Console.Write($"\n3.1 Nhap So Can Kiem Tra: ");
int q = int.Parse(Console.ReadLine());
KtraX(a, q);
//3.2
Console.Write("3.2 Nhap So Can Tim So Lan Xuat Hien : ");
int s = int.Parse(Console.ReadLine());
TimSoLanXuatHienValue(a, s);
//3.3
Console.WriteLine("3.3 Vi Tri Cua Phan Tu X Trong Danh Sach :");
TimTatCaVtriCuaPhanTuX(a, s);
//3.4
Console.WriteLine("\n3.4");
TimVTDauTienList(a);
//3.5
Console.WriteLine("3.5 ");
TimVTCuoiCung(a);
//3.6
Console.WriteLine($"\n3.6 Cac So DUONG Trong Danh Sach La : ");
TimVTSoDuong(a);
//3.7
Console.WriteLine($"\n3.7 Cac So AM Trong Danh Sach La : ");
TimVTSoAm(a);
//3.8





//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Dinh Nghia Ham
//1.1 Nhập từ bàn phím
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

//1.2	Nhập ngẫu nhiên
static void NhapNgauNhien(List<int> a)
{
    int length = 0;
    Console.Write("\nNhap vao chieu dai mang : ");
    length = int.Parse(Console.ReadLine());
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
        a.Add(r.Next(-100,101));
    }
}

//1.3 Nhập từ File
//static void DocFile(List<int> a)
//{
//    string s;
//    Console.Write("\nDoc File : \n");
//    StreamReader sr = new StreamReader("docfile.txt");
//    // Đọc từng dòng trong file 
//    while ((s = sr.ReadLine()) != null)
//    {
//        a.Add(int.Parse(s));
//    }
//}

static void DocFile(List<int> a, string s)
{
    StreamReader sr = new StreamReader(s);
    while((s = sr.ReadLine()) != null)
    {
        a.Add(int.Parse(s));
    }
}

//1.4 Xuất ra Console
static void Xuat(List<int> a)
{
    Khung();
    foreach (int i in a)
    {
        Console.Write($"{i}\t");
    }
    Console.WriteLine();
    Khung();
}

//1.5 Xuất ra File
static void XuatFile(List<int> a, string s)
{
    StreamWriter sw = new StreamWriter(s);
    foreach (int i in a)
    {
        sw.WriteLine($"{i}  ");
    }
    sw.Flush();
    sw.Close();
}


//2.1	Tính tổng các phần tử trong danh sách.
static int TinhTong(List<int> a)
{
    int sum = 0;
    for(int i = 0; i < a.Count; i++)
    {
        sum += a[i];
    }
    return sum;
}

//2.2	Tính trung bình các phần tử trong danh sách.
static double TinhTB(List<int> a)
{
    double dem = TinhTong(a) / a.Count;
    return dem;
}

//2.3	Tìm giá trị lớn nhất trong danh sách.
static int TimMAX(List<int> a)
{
    return a.Max();
}

//2.4	Tìm giá trị nhỏ nhất trong danh sách.
static int TimMIN(List<int> a)
{
    return a.Min();
}

//2.5	Tìm số lần xuất hiện của một giá trị trong danh sách.
static int TimSoLanXuatHien(List<int> a, int x)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == x)
            dem++;
    }
    return dem;
}

//2.6	Tính tổng các số âm trong danh sách.
static int TinhTongSoAm(List<int> a)
{
    int temp = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] < 0)
            temp += a[i];
    }
    return temp;
}

//2.7	Tính tổng các số dương trong danh sách.
static int TinhTongSoDuong(List<int> a)
{
    int sum = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > 0)
            sum += a[i];
    }
    return sum;
}

//2.8	Đếm số chẵn
static int DemSoChan(List<int> a)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] % 2 == 0)
            dem++;
    }
    return dem;
}

//2.9	Đếm số lẽ
static int DemSoLe(List<int> a)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (!(a[i] % 2 == 0))
            dem++;
    }
    return dem;
}

//2.10	Đếm phần tử x trong danh sách
static int DemPhanTuX(List<int> a, int x)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == x)
            dem++;
    }
    return dem;
}
static void Khung()
{
    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
}

//3.1	Kiểm tra phần tử x có chứa trong danh sách hay không
static void KtraX(List<int> a, int q)
{
    foreach (int i in a)
    {
        if (i == q)
        {
            Console.WriteLine($"==> Phan Tu {q} Co Trong Danh Sach");
            return;
        }
    }
    Console.WriteLine("==> Khong co  ");
    return;
}

//3.2	Tìm số lần xuất hiện của một giá trị trong danh sách
static void TimSoLanXuatHienValue(List<int> a, int s)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == s)
            dem++;
    }
    Console.WriteLine($"==> So Lan Xuat Hien Cua {s} La : {dem}.");
}

//3.3	Tìm tất cả vị trí của phần tử x trong danh sách
static void TimTatCaVtriCuaPhanTuX(List<int> a, int s)
{
    Console.Write("==> ");
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == s)

        {
            Console.Write($"\t{i}");
        }
    }
}

//3.4	Tìm vị trí đầu tiên của phần tử trong danh sách
static void TimVTDauTienList(List<int> a)
{
    for (int i = 0; i < a.Count; i++)
    {
        Console.WriteLine($"==> Vi Tri DAU TIEN Cua Phan Tu Trong LIST La : {i}");
        break;
    }
}
//3.5	Tìm vị trí cuối cùng của phần tử x trong danh sách
static void TimVTCuoiCung(List<int> a)
{
    for (int i = a.Count - 1; i >= 0; i--)
    {
        Console.WriteLine($"==> Vi Tri CUOI CUNG Cua Phan Tu Trong LIST La : {i}");
        break;
    }
}
//3.6	Tìm vị trí của các số dương trong danh sách
static void TimVTSoDuong(List<int> a)
{
    int vitri;
    Console.WriteLine("==> ");
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > 0)
        {
            Console.Write($"   {i}");
        }
    }

}
//3.7	Tìm vị trí của các số âm trong danh sách
static void TimVTSoAm(List<int> a)
{
    int vitri;
    Console.WriteLine("==> ");
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] < 0)
        {
            Console.Write($"   {i}");
        }
    }

}
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





