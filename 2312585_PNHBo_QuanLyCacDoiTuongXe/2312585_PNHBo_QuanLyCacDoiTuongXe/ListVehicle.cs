using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312585_PNHBo_QuanLyCacDoiTuongXe
{
    internal class ListVehicle
    {
        List<Vehicle> ds = new List<Vehicle>();
        public void Them(Vehicle n)
        {
            ds.Add(n);
        }

        public void DocFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string s = "";
            while((s = sr.ReadLine()) != null) 
            {
                if (s.Contains("Car"))
                {
                    Vehicle car = new Car(s);
                    ds.Add(car);
                }
                else if (s.Contains("Motorcycle"))
                {
                    Vehicle motorcycle = new Motorcycle(s);
                    ds.Add(motorcycle);
                }
                else
                {
                   
                }
            }
        }

        public void Xuat()
        {
            foreach (Vehicle n in ds)
            {
                Console.WriteLine(n);
            }
        }
    }
}
