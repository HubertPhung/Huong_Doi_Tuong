
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
List<int> a = new List<int> { };
List<int> b = new List<int> { 12, 8, 9, -5, -1, 7, -8, 6 };
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
Console.WriteLine("Xuat mang a : ");
Xuat(a);
Console.WriteLine("Xuat mang b : ");
Xuat(b);
//1.5	Xuất ra File
//XuatFile(a, s);



TheLine();
//2.1
Console.WriteLine($"\n2.1 Tong cua cac phan tu trong List la : {TinhTong(a)}.");
TheLine();
//2.2
Console.WriteLine($"2.2 Tinh trung binh cua List la : {TinhTB(a)}.");
TheLine();
//2.3
Console.WriteLine($"2.3 Gia Tri Lon Nhat La : {TimMAX(a)}.");
TheLine();
//2.4
Console.WriteLine($"2.4 Gia Tri Nho Nhat La : {TimMIN(a)}.");
TheLine();
//2.5
Console.Write("2.5 Nhap So Can Tim So Lan Xuat Hien (x) : ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine($"==> So Lan Xuat Hien Cua {x} La : {TimSoLanXuatHien(a, x)}.");
TheLine();
//2.6
Console.WriteLine($"2.6 Tinh Tong Cac So Am Trong Danh Sach La : {TinhTongSoAm(a)}.");
TheLine();
//2.7
Console.WriteLine($"2.7 Tinh Tong Cac So Duong Trong Danh Sach La : {TinhTongSoDuong(a)}.");
TheLine();
//2.8
Console.WriteLine($"2.8 So Chan Trong Danh Sach Co {DemSoChan(a)} So.");
TheLine();
//2.9
Console.WriteLine($"2.9 So Le Trong Danh Sach Co {DemSoLe(a)} So.");
TheLine();
//2.10
Console.WriteLine($"2.10 Phan Tu {x} Trong Danh Sach Co {DemPhanTuX(a, x)} So.");
TheLine();

//3.1
Console.WriteLine("Xuat mang a : ");
Xuat(a);
Console.Write($"\n3.1 Nhap So Can Kiem Tra: ");
int q = int.Parse(Console.ReadLine());
KtraX(a, q);
TheLine();
//3.2
Console.Write("3.2 Nhap So Can Tim So Lan Xuat Hien : ");
int s = int.Parse(Console.ReadLine());
TimSoLanXuatHienValue(a, s);
TheLine();
//3.3
Console.WriteLine("3.3 Vi Tri Cua Phan Tu X Trong Danh Sach :");
Console.WriteLine("==> ");
TimTatCaVtriCuaPhanTuX(a, s);
TheLine();
//3.4
Console.WriteLine("\n3.4");
TimVTDauTienList(a);
TheLine();
//3.5
Console.WriteLine("3.5 ");
TimVTCuoiCung(a);
TheLine();
//3.6
Console.WriteLine($"\n3.6 Cac So DUONG Trong Danh Sach La : ");
Console.Write("==> ");
TimVTSoDuong(a);
TheLine();
//3.7
Console.WriteLine($"\n3.7 Cac So AM Trong Danh Sach La : ");
Console.Write("==> ");
TimVTSoAm(a);
TheLine();
//3.8
Console.WriteLine($"\n3.8 Tim vi tri cua so lon nhat trong danh sach");
Console.WriteLine($"==> So lon nhat la {TimMAX(a)} va nam o vi tri {TimVTLonNhat(a)}. ");
TheLine();

//3.9
Console.WriteLine("\n3.9 Tim vi tri cua so nho nhat trong danh sach");
Console.WriteLine($"==> So nho nhat la {TimMIN(a)} va nam o vi tri {TimVTNhoNhat(a)}. ");
TheLine();

//3.10
Console.WriteLine("\n3.10 Tim tat ca cac so chan trong danh sach");
TimALLSoChan(a);
TheLine();

//3.11
Console.WriteLine("\n3.11 Tim tat ca cac so le trong danh sach");
TimALLSoLe(a);
TheLine();

//3.12
Console.WriteLine();
Console.Write("3.12 Tim so nguyen xuat hien nhieu nhat trong danh sach : ");
Console.WriteLine(TimSoNguyenXuatHienNhieuNHat(a));
TheLine();
//3.13
Console.Write("3.13 Tim so nguyen xuat hien it nhat trong danh sach : ");
Console.WriteLine(TimSoNguyenXuatHienItNhat(a));
TheLine();

//3.14
Console.WriteLine("3.14 Tim so nguyen xuat hien it nhat trong danh sach.");
XuatMang(MangKoTrungLap(a));
TheLine();

//3.15
Console.WriteLine("\n3.15 Cac phan tu trong danh sach va so lan xuat hien la: ");
XuatMang(TimCacPhanTuTrongDS(a));
XuatMang(SoLanXuatHienCuaCacPhanTu(a));
TheLine();

//3.16
Console.WriteLine("3.16 Hop 2 danh sach c= a U b ");
Console.WriteLine("Danh sach a: ");
XuatMang(a);
Console.WriteLine("\nDanh sach b: ");
XuatMang(b);
Console.WriteLine("\nDanh sach sau khi hop c: ");
XuatMang(HopHaiDanhSach(a, b));

//3.17
TheLine();
Console.WriteLine("3.17 Giao 2 danh sach c= a n b ");
Console.WriteLine("Danh sach a: ");
XuatMang(a);
Console.WriteLine("\nDanh sach b: ");
XuatMang(b);
Console.WriteLine("\nDanh sach sau khi giao c: ");
XuatMang(GiaohaiDanhSach(TimCacPhanTuTrongDS(a), b));

//3.18
TheLine();
Console.WriteLine("3.18 Hieu 2 danh sach c= a / b ");
Console.WriteLine("Danh sach a: ");
XuatMang(a);
Console.WriteLine("\nDanh sach b: ");
XuatMang(b);
Console.WriteLine("\nDanh sach sau khi hieu c: ");
XuatMang(HieuhaiDanhSach(a, b));
TheLine();

//4.1
int temp = 0;
Console.WriteLine("\n4.1 Sap xep danh sach theo thu tu TANG DAN la :");
XuatMang(OrderByAscending(a));
TheLine();
//4.2
Console.WriteLine("\n4.2 Sap xep danh sach theo thu tu GIAM DAN la :");
XuatMang(OrderByDescending(a));
TheLine();

//5.1
Console.WriteLine("\n");
Xuat(a);
int vt;
Console.WriteLine("5.1 Xoa phan tu tai vi tri trong danh sach. ");
Console.Write("Nhap vi tri can xoa : ");
vt = int.Parse(Console.ReadLine());
XuatMang(XoaTaiVT(a, vt));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.2
Console.WriteLine("5.2 Xoa phan tu DAU TIEN trong danh sach. ");
XuatMang(XoaTaiVT(a, 0));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.3
Console.WriteLine("5.3 Xoa phan tu CUOI CUNG trong danh sach. ");
XuatMang(XoaTaiVT(a, a.Count - 1));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.4
Console.WriteLine("5.4 Xoa tat ca danh sach. ");
XuatMang(XoaAllList(a));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.5
int lonhon;
Console.WriteLine("5.5 Xoa tat ca cac so lon hon X. ");
Console.WriteLine("Nhap X: ");
lonhon = int.Parse(Console.ReadLine());
XuatMang(XoaAllSoLonHonX(a, lonhon));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.6
Console.WriteLine("5.6 Xoa tat ca cac so DUONG. ");
XuatMang(XoaAllSoLonHonX(a, 0));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.7
Console.WriteLine("5.7 Xoa tat ca cac so Chan. ");
XuatMang(XoaAllSoChan(a));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.8
Console.WriteLine("5.8 Xoa tat cac so nguyen to. ");
XuatMang(XoaAllSoNguyenTo(a));
Console.WriteLine("\nDa xoa!");
TheLine();

//5.9
Xuat(a);
Console.WriteLine("5.9 Them mot phan tu tai vi tri vt trong danh sach. ");
Console.Write("Nhap vi tri can them vao : ");
int vt1 = int.Parse(Console.ReadLine());
Console.Write("Nhap gia tri can them vao : ");
int add = int.Parse(Console.ReadLine());
XuatMang(Them1PhanTu(a, vt1, add));
Console.WriteLine("\nDa Them!");
TheLine();

//5.10
Console.WriteLine("5.10 Them phan tu dau tien trong danh sach. ");
XuatMang(Them1PhanTu(a, 0, add));
Console.WriteLine("\nDa Them!");
TheLine();

//5.11
Console.WriteLine("5.11 Them phan tu vao cuoi danh sach. ");
XuatMang(Them1PhanTu(a, a.Count, add));
Console.WriteLine("\nDa Them!");
TheLine();
//5.12
Console.WriteLine("5.12 Them 1 danh sach so nguyen tai 1 vt trong danh sach. ");
Console.Write("Nhap vi tri can them vao :  ");
int intergerlocation = int.Parse(Console.ReadLine());
Console.Write("Nhap so gia tri can them vao :  ");
int length = int.Parse(Console.ReadLine());
List<int> inputarray = new List<int>();
for (int i = 1; i <= length; i++)
{
    Console.Write("Gia tri cua mang " + i + ":  ");
    inputarray.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("Danh sach sau khi thay doi :  ");
XuatMang(Them1SoNguyen(a, vt1, inputarray));
TheLine();

//5.13
Console.WriteLine();
Console.WriteLine("5.13 Them 1 danh sach so nguyen vao vt CUOI CUNG trong danh sach. ");
Console.WriteLine("Danh sach sau khi thay doi :  ");
XuatMang(Them1SoNguyen(a, a.Count, inputarray));
TheLine();

//5.14
Console.WriteLine();
Console.WriteLine("5.14 Them 1 danh sach so nguyen vao DAU danh sach. ");
Console.WriteLine("Danh sach sau khi thay doi :  ");
XuatMang(Them1SoNguyen(a, 0, inputarray));
TheLine();

//5.15
Console.WriteLine();
Console.WriteLine("5.15 Dao nguoc thu tu cac phan tu trong danh sach. ");
Console.WriteLine("Danh sach sau khi thay doi :  ");
XuatMang(DaoNguocThuTu(a));
TheLine();
//5.17
Console.WriteLine();
Console.WriteLine("5.17 Thay the phan tu x thanh phan tu y. ");
Console.Write("Nhap x de thay the:  ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Nhap y de thay the:  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Danh sach sau khi thay doi:  ");
XuatMang(ThayTheXBangY(a, x1, y));
TheLine();

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

//1.2 Nhập ngẫu nhiên
static void NhapNgauNhien(List<int> a)
{
    int length = 0;
    Console.Write("\nNhap vao chieu dai mang a : ");
    length = int.Parse(Console.ReadLine());
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
        a.Add(r.Next(-10, 11));
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
    int temp = 0;
    Khung();
    foreach (int i in a)
    {
        Console.Write($"{i}\t");
        temp++;
        if (temp % 12 == 0)
            Console.WriteLine();
    }
    Console.WriteLine();
    Khung();
}

static void XuatMang(List<int> a)
{
    int temp = 0;
    foreach (int i in a)
    {

        Console.Write(i + "\t");
        temp++;
        if (temp % 12 == 0)
            Console.WriteLine();
    }
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
        if (KtraSoChan(a[i]) && KtraSoDuong(a[i]))
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
        if (KtraSoLe(a[i]) && KtraSoDuong(a[i]))
            dem++;
    }
    return dem;
}

//2.10	Đếm phần tử x trong danh sách
static int DemPhanTuX(List<int> a, int z)
{
    int dem = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] == z)
            dem++;
    }
    return dem;
}
static void Khung()
{
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
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
    
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] < 0)
        {
            Console.Write($"   {i}");
        }
    }

}
//3.8	Tìm vị trí của số lớn nhất trong danh sách
static int TimVTLonNhat(List<int> a)
{
    int solonnhat = TimMAX(a);
    int vitrisolonnhat = a.IndexOf(solonnhat);
    return vitrisolonnhat;
}
//3.9	Tìm vị trí của số nhỏ nhất trong danh sách
static int TimVTNhoNhat(List<int> a)
{
    int sonhonhat = TimMIN(a);
    int vitrisonhonhat = a.IndexOf(sonhonhat);
    return vitrisonhonhat;
}
//3.10	Tìm tất cả số chẵn trong danh sách
static bool KtraSoChan(int soChan)
{
    if (soChan % 2 == 0) return true;
    return false;
}

static bool KtraSoLe(int soChan)
{
    if (soChan % 2 == 1) return true;
    return false;
}

static bool KtraSoDuong(int soChan)
{
    if(soChan > 0) return true;
    return false;
}
static void TimALLSoChan (List<int> a)
{
  
    int temp = 0;
    for(int i = 0; i < a.Count;i++)
    {
        if (KtraSoChan(a[i]) && KtraSoDuong(a[i]))
        {
            Console.Write(a[i] + "\t");
            temp++;
            if (temp % 11 == 0)
                Console.WriteLine();
        }
    }
}
//3.11	Tìm tất cả số lẽ trong danh sách
static void TimALLSoLe(List<int> a)
{
    int temp = 0;
    for (int i = 0; i < a.Count; i++)
    {
        if (KtraSoLe(a[i])&& KtraSoDuong(a[i]))
        {
            Console.Write(a[i] + "\t");
            temp++;
            if (temp % 11 == 0)
                Console.WriteLine();
        }
    }
}
//3.12	Tìm số nguyên xuất hiện nhiều nhất trong danh sách
static List<int> SoLanXuatHien(List<int> a)
{
    List<int> temp = new List<int>();
    foreach (int i in a)
    {

        temp.Add(TimSoLanXuatHien(a, i));
    }
    return temp;
}
static int TimSoNguyenXuatHienNhieuNHat(List<int> a)
{
    int kq = a[SoLanXuatHien(a).IndexOf(SoLanXuatHien(a).Max())];
    return kq;
}
//3.13	Tìm số nguyên xuất hiện ít nhất trong danh sách
static int TimSoNguyenXuatHienItNhat(List<int> a)
{
    int kq = a[SoLanXuatHien(a).IndexOf(SoLanXuatHien(a).Min())];
    return kq;
}
//3.14	Tìm tất cả các phần tử trong danh sách (không trùng nhau). Ví dụ danh sách 1 2 3 1 2 thì trả về 1 2 3 
static bool KtraXcoTrongMang(List<int> a, int x)
{
    foreach (int i in a) {
        if (x == i) return false;
        
    }
    return true;
}
static List<int> MangKoTrungLap(List<int> a)
{
    List<int> b = new List<int>();
    foreach (int i in a)
    {
        if (KtraXcoTrongMang(b, i)) 
            b.Add(i);
    }
    return b;
}

//3.15	Tìm số lần xuất hiện của các phần tử trong danh sách
//3.16	Tìm vị trí đầu tiên của danh sách x trong danh sách. Ví dụ: với danh sách 1 2 3 4 5 2 3 và mảng x là 2 3 thì vị trí trả về là 2
//3.17	Tìm vị trí cuối cùng của danh sách x trong danh sách. 
//3.18	Tìm hợp của 2 danh sách
//3.19	Tìm giao của 2 danh sách
//3.20	Tìm hiệu của 2 danh sách
//3.21	Tìm phần tử xuất hiện ít nhất trong danh sách
//3.22	Tìm phần tử xuất hiện nhiều nhất trong danh sách


static List<int> TimCacPhanTuTrongDS(List<int> a)
{
    List<int> b = new List<int> { };
    foreach (int i in a)
    {
        if (!b.Contains(i)) b.Add(i);
    }
    return b;

}
static int DemSoLanXuatHienX(int x, List<int> a)
{
    int count = 0;
    foreach (int i in a)
    {
        if (i == x)
        {
            count++;
        }
    }
    return count;
}
static List<int> SoLanXuatHienCuaCacPhanTu(List<int> a)
{
    List<int> b = new List<int>();
    foreach (int i in TimCacPhanTuTrongDS(a))
    {
        b.Add(DemSoLanXuatHienX(i, a));
    }

    return b;
}
static void TheLine()
{
    Console.WriteLine("\n=====================================================================================\n");
}
static List<int> LocatedTheMaximumNum(int n, List<int> a)
{

    List<int> Locate = new List<int>();
    for (int i = 0; i < n; i++)
    {
        if (a[i] == a.Max())
            Locate.Add(i);
    }
    return Locate;
}
static List<int> LocatedTheMinimumNum(int n, List<int> a)
{

    List<int> Locate = new List<int>();
    for (int i = 0; i < n; i++)
    {
        if (a[i] == a.Min())
            Locate.Add(i);
    }
    return Locate;
}
static bool EvenNumChecker(int a)
{
    bool result = false;
    if (a % 2 == 0 && PositiveChecker(a)) result = true;
    return result;
}
static bool OddNumChecker(int a)
{
    bool result = false;
    if (a % 2 == 1 && PositiveChecker(a)) result = true;
    return result;
}
static bool PositiveChecker(int a)
{
    bool result = false;
    if (a >= 0)
        result = true;
    return result;
}
static List<int> EvenNum(List<int> a)
{
    List<int> b = new List<int> { };
    foreach (int i in TimCacPhanTuTrongDS(a))
    {
        if (EvenNumChecker(i)) b.Add(i);
    }

    return b;
}
static List<int> OddNum(List<int> a)
{
    List<int> b = new List<int> { };
    foreach (int i in TimCacPhanTuTrongDS(a))
    {
        if (OddNumChecker(i)) b.Add(i);
    }

    return b;
}
static int IndexSoNguyenXuatHienNhieuNhat(List<int> a)
{

    return SoLanXuatHienCuaCacPhanTu(a).IndexOf(SoLanXuatHienCuaCacPhanTu(a).Max());

}
static int IndexSoNguyenXuatHienItNhat(List<int> a)
{

    return SoLanXuatHienCuaCacPhanTu(a).IndexOf(SoLanXuatHienCuaCacPhanTu(a).Min());

}
static List<int> HopHaiDanhSach(List<int> a, List<int> b)
{
    List<int> Kq = new List<int> { };
    Kq.AddRange(b);
    Kq.AddRange(a);

    return TimCacPhanTuTrongDS(Kq);
}
static List<int> GiaohaiDanhSach(List<int> a, List<int> b)
{
    List<int> kq = new List<int>();
    foreach (int i in a)
    {
        if (b.Contains(i))
        {
            kq.Add(i);
        }
    }
    return kq;
}
static List<int> HieuhaiDanhSach(List<int> a, List<int> b)
{
    List<int> kq = new List<int>();
    foreach (int i in a)
    {
        if (!b.Contains(i))
        {
            kq.Add(i);
        }
    }
    return kq;
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

//5.1 Xóa phần tử tại vị trí vt trong danh sách
static List<int> XoaTaiVT(List<int> a, int vt)
{
    List<int> mang = new List<int>(a);
    mang.RemoveAt(vt);
    return mang;
}


//5.2	Xóa phần tử đầu tiên trong danh sách
//5.3	Xóa phần tử cuối cùng trong danh sách
//5.4	Xóa tất cả danh sách
static List<int> XoaAllList(List<int> a)
{
    List<int> mang = new List<int>(a);
    mang.Clear();
    return mang;
}
//5.5	Xóa tất cả các số lớn hơn x
static List<int> XoaAllSoLonHonX(List<int> a, int lonhon)
{
    List<int> mang = new List<int>(a);
    mang.RemoveAll(x => x > lonhon);    
    return mang;
}
//5.6	Xóa tất cả số dương
//5.7	Xóa tất cả số chẵn
static List<int> XoaAllSoChan(List<int> a)
{
    List<int> mang = new List<int>(a);
    mang.RemoveAll(x => x % 2 == 0);
    return mang;
}
//5.8	Xóa tất cả số nguyên tố
static List<int> XoaAllSoNguyenTo(List<int> a)
{
    List<int> mang = new List<int>(a);
    mang.RemoveAll(IsPrime);
    return mang;
}
static bool IsPrime(int prime)
{
    if (prime <= 1)
        return false;
    if (prime <= 3)
        return true;
    if (prime % 2 == 0)
        return false;
    int i = 5;
    while (i * i <= prime)
    {
        if (prime % i == 0 || prime % (i + 2) == 0)
            return false;
        i += 6;
    }
    return true;
}

//5.9	Thêm một phần tử tại vị trí vt trong danh sách
static List<int> Them1PhanTu(List<int> a, int vt1, int add)
{
    List<int> mang = new List<int>(a);
    mang.Insert(vt1, add);
    int temp = 0;
    return mang;
}
//5.10	Thêm phần tử đầu tiên trong danh sách 
//5.11	Thêm phần tử vào cuối danh sách 
//5.12	Thêm một danh sách số nguyên tại vị trí vt của danh sách
static List<int> Them1SoNguyen(List<int> a, int vt1, List<int> inputarray)
{
    List<int> mang = new List<int>(a);
    mang.InsertRange(vt1, inputarray);
    return mang;
}

//5.13	Thêm một danh sách số nguyên vào cuối danh sách.
//5.14    Thêm một danh sách số nguyên vào đầu danh sách
//5.15    Đảo ngược thứ tự các phần tử trong danh sách
static List<int> DaoNguocThuTu(List<int> a)
{
    int temp = 0;
    List<int> mang = new List<int>(a);
    mang.Reverse();
    return mang;
}

//5.16	Đảo lộn vị trí các phần tử trong danh sách ngẫu nhiên
static List<int> DaoNguocThuTuNgauNhien(List<int> a)
{
    List<int> mang = new List<int>(a);
    mang.Reverse();
    return mang;
}
//5.17	Thay thế phần tử x bằng phần tử y
static List<int> ThayTheXBangY(List<int> a, int x1, int y)
{
    List<int> mang = new List<int>(a);
    for (int i = 0; i < mang.Count; i++)
    {
        if (mang[i] == x1)
        {
            mang[i] = y;
        }
    }
    
    return mang;
}

