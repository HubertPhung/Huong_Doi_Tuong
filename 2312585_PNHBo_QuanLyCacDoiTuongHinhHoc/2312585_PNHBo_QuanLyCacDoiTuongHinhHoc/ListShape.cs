using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongHinhHoc
{
    internal class ListShape
    {
        List<Shape> ds = new List<Shape>();
       
        public void DocFile(string tenfile)
        {
            StreamReader sr = new StreamReader(tenfile);
            string s = "";
            
            while ((s = sr.ReadLine()) != null) 
            {
                string[] t = s.Split(',');
                if (t[0] == "Circle")
                {
                    Shape circle = new Circle(double.Parse(t[1]));
                    ds.Add(circle);

                }

                else if (t[0] == "Rectangle")
                {
                    Shape rectangle = new Rectangle(double.Parse(t[1]), double.Parse(t[2]));
                    ds.Add (rectangle);
                }
                else if (t[0]== "Triagle")
                {
                    Shape triagle = new Triangle(double.Parse(t[1]), double.Parse(t[2]), double.Parse(t[3]));
                    ds.Add(triagle);
                }
           

            }
        }

        public void Xuat()
        {
            foreach(Shape n in ds)
            {
                Console.WriteLine(n);
                Console.WriteLine();
            }
        }
    }
}
