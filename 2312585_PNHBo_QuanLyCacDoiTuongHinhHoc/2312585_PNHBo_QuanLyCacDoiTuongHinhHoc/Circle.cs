using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongHinhHoc
{
    public  class Circle : Shape
    {
        public double radius {  get; set; }
        public Circle (double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Permeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Vẽ hình tròn...");
        }

        public Circle(string tb)
        {
            string[] s = tb.Split(',');
            radius = double.Parse(s[0]);
        }

        

        public override string ToString()
        {
            return string.Format("Shape : {0}\nRadius : {1}\nArea : {2}\nPermeter : {3}\n{4}","Circle",radius,Area(),Permeter(),"Circle drawing....");
        }



    }
}
