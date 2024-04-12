using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongHinhHoc
{
    public abstract class Shape
    {
        
        public abstract double Area();
        public abstract double Permeter();

        public virtual void Draw()
        {
            Console.WriteLine("Vẽ hình...");
        }
        
    }
}
