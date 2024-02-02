
List<int> a = new List<int>();
//Nhap Mảng Từ Bàn Phím
NhapMang(a);
Xuat(a);
a.Clear();
// Nhập xuất 
NhapNgauNhien(a);
Xuat(a);
a.Clear();
// Doc File va Xuat File 
DocFile(a);
Xuat(a);
a.Clear();


//List<int> a = new List<int> { 1, 2, 3, 4 , 5, 6 ,7 ,8};


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

static void NhapNgauNhien(List<int> a)
{
    int length = 0;
    Console.Write("\nNhap vao chieu dai mang : ");
    length = int.Parse(Console.ReadLine());
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
        a.Add(r.Next(10));
    }
}

static void Xuat(List<int> a)
{
    foreach(int i in a)
    {
        Console.Write($"{i}   ");

    }
}

//static void DocFile(List<int> a)
//{
//    string s;
//    Console.Write("\nDoc File : \n");
//    StreamReader sr = new StreamReader("docfile.txt");
//    // Đọc từng dòng trong file 
//    while((s = sr.ReadLine()) != null)
//    {
//        a.Add(int.Parse(s));
//    }
//}

static void DocFile(List<int> a)
{

    Console.Write("\nNhap ten file can doc (docfile.txt) : ");
     string x = Console.ReadLine();
    StreamReader sr = new StreamReader(x);
    while((x = sr.ReadLine()) != null)
    {
        a.Add(int.Parse(x));
    }
}

//static void XuatFile(List<int> a, string x)
//{
//    StreamWriter sw = new StreamWriter(x);
//    foreach (int i in a)
//    {
//        sw.WriteLine($"{i}  ");
//    }
//    sw.Flush();
//    sw.Close();
//}
