using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongXe
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string wheelnumber, string name, string speed, string brandname): base(name, speed, brandname)
        {
            Wheelnumber = wheelnumber;
        }

        public string Wheelnumber {  get; set; }
        public override void Move()
        {
            Console.WriteLine("Motorcycle is moving...");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping...");
        }

        public Motorcycle(string tb) : base(tb)
        {
            string[] s = tb.Split(',');
            Wheelnumber = s[0];
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Wheel number : {0}",Name,Speed,Brandname, Wheelnumber);
        }
    }
}
