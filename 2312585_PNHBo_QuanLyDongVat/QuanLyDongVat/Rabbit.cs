using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDongVat
{
    internal class Rabbit : Animal
    {
        public string Breed {  get; set; }

        public string Color { get; set; }

        public override void Speak()
        {
            Console.WriteLine("Măm măm");
        }

        public void Eat()
        {
            Console.WriteLine("Carrot... măm măm");
        }
    }
}
