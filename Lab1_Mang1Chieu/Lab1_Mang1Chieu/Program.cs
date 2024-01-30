
List<int> a = new List<int>();
NhapNgauNhien(a);
Xuat(a);

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