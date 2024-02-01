
List<int> a = new List<int>();
// Nhập xuất 
NhapNgauNhien(a);
Xuat(a);
// Doc File va Xuat File 
string x;
Console.Write("\nNhap ten file can doc (docfile.txt) : ");
x = Console.ReadLine();
DocFile(a, x);
XuatFile(a, x);


//List<int> a = new List<int> { 1, 2, 3, 4 , 5, 6 ,7 ,8};

static void NhapNgauNhien(List<int> a)
{
    int length = 0;
    Console.Write("Nhap vao chieu dai mang : ");
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

static void DocFile(List<int> a, string x)
{
   
    StreamReader sr = new StreamReader(x);
    while((x = sr.ReadLine()) != null)
    {
        a.Add(int.Parse(x));
    }
}

static void XuatFile(List<int> a, string x)
{
    string s = x.Trim();
    StreamWriter sw = new StreamWriter(s);
    foreach (int i in a)
    {
        sw.WriteLine($"{i}  ");
    }
    sw.Flush();
    sw.Close();
}
