

using _2312585_PNHBo_QuanLyCacDoiTuongHinhHoc;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//Shape hTron = new Circle(5);
//Shape hVuong = new Rectangle(4, 6);

//Console.WriteLine("Diện tích hình tròn: " + hTron.Area());
//Console.WriteLine("Chu vi hình tròn: " + hTron.Permeter());
//hTron.Draw();

//Console.WriteLine("Diện tích hình vuông: "+ hVuong.Area());
//Console.WriteLine("Chu vi hình vuông: "+ hVuong.Permeter());
//hVuong.Draw();

ListShape ds = new ListShape();
ds.DocFile("data.txt");
ds.Xuat();

