using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongHinhHoc
{
    internal class Rectangle : Shape
    {
        public double length {  get; set; }
        public double width { get; set; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Permeter()
        {
            return 2 * length + 2 * width;
        }

        public override void Draw()
        {
            Console.WriteLine("Vẽ hình vuôngS...");
        }

        public Rectangle (string tb)
        {
            string[] s = tb.Split(',');
            length = double.Parse(s[0]);
            width = double.Parse(s[1]);
        }

        public override string ToString()
        {
            return string.Format("Shape : {0}\nLength : {1}\nWidth : {2}\nArea : {3}\nPermeter : {4}\n{5}","Rectangle", length, width,Area(),Permeter(),"Rectangle drawing....");
        }
    }
}
