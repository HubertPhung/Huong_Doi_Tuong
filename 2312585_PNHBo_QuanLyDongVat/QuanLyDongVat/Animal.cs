using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDongVat
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Lenght {  get; set; }

        public virtual void  Speak()
        {
            Console.WriteLine("Thú đang kêu....");
        }

    }
}
