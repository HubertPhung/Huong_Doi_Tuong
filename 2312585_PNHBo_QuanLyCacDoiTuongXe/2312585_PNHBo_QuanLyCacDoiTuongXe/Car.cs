using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongXe
{
    internal class Car : Vehicle
    {
        public Car(string color, string name, string speed, string brandname) : base(name, speed, brandname)
        {
            Color = color;
        }

        public string Color { get; set; }
       
        public override void Move()
        {
            Console.WriteLine("Car is moving...");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }
        public Car (string tb) : base(tb)
        {
            string[] s=tb.Split(',');
            Color = s[0];
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Color : {0}",Name,Speed,Brandname, Color);
        }
    }
}
