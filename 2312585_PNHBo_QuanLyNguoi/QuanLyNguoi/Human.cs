using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoi
{
    internal class Human
    {
        public string Name { get; set; }
        public string Kind {  get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Speed { get; set; }
        public string career { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("Human language");
        }

   

    }
}
