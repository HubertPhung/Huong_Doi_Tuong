using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongHinhHoc
{
    internal class Triangle : Shape
    {
        public Triangle(double canh1, double canh2, double canh3)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }

        public double canh1 {  get; set; }
        public double canh2 {  get; set; }
        public double canh3 {  get; set; }

        public bool IsTriagle
        {
            get{
                return canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh2 > canh1;
            }
        }
        public override double Area()
        {
            double s = Permeter() / 2;
            return  Math.Round(Math.Sqrt(s*(s- canh1)*(s- canh2)*(s-canh3)));
        }

        public override double Permeter()
        {
            return canh1 + canh2 +canh3;
        }

        public double Highroad()
        {
            return 2 * (Area() / canh1);
        }

        public Triangle (string tb)
        {
            string[] s= tb.Split(' ');
        }

        public override string ToString()
        {
            return string.Format("Shape : {0}\nCanh1 : {1}\nCanh2 : {2}\nCanh3 : {3}\nArea : {4}\nPermeter : {5}\nHighroad : {6}\n{7}", "Triagle", canh1, canh2, canh3, Area(), Highroad(), Permeter(), "Circle drawing....");
        }
    }
}
