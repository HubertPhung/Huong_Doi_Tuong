using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongXe
{
    internal class Vehicle
    {
        public Vehicle(string name, string speed, string brandname)
        {
            Name = name;
            Speed = speed;
            Brandname = brandname;
        }

        public string Name { get; set; }
        public string Speed { get; set; }
        public string Brandname {  get; set; }
        
        public virtual void Move()
        {

        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping........");
        }

        public Vehicle()
        {

        }
        public Vehicle(string tb)
        {
            string[] s = tb.Split(',');
            Name = s[0];
            Speed = s[1];
            Brandname = (string)s[2];
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Name : {0}\nSpeed : {1}\n", Name, Speed);
        }

    }
}
